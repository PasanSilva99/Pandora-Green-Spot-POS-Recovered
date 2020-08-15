using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pandora_Green_Spot_POS
{
    class ReportAnalysis
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\PandoraGreenSpot\Pandora.mdf;Integrated Security=True;Connect Timeout=30");

        private int getTotalQty()
        {
            string qry1 = $"SELECT SUM(Qty) FROM Bill";

            SqlDataAdapter adptTotalQty = new SqlDataAdapter(qry1, con);
            DataTable tblTotalQty = new DataTable();

            adptTotalQty.Fill(tblTotalQty);

            return (int)tblTotalQty.Rows[0][0];
        }

        private int getSelectedQty(int itemID)
        {
            string qry2 = $"SELECT SUM(Qty) FROM Bill WHERE itemID = {itemID}";
            SqlDataAdapter adptPQty = new SqlDataAdapter(qry2, con);
            DataTable tblPQty = new DataTable();

            adptPQty.Fill(tblPQty);

            int total = 0;
            try
            {
                total = Convert.ToInt32(tblPQty.Rows[0][0]);
            }
            catch
            {
                //no need but need
            }

            return total;
        }

        private void FillPopularity(int itemID)
        {
            double totalQty = getTotalQty();
            double totalSelected = getSelectedQty(itemID);

            double popularity = totalSelected / totalQty * 100;



            string qry = $"UPDATE Product SET [Popularity] = '{popularity}' WHERE itemID = '{itemID}'";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Updating Popularity. Contact your IT Administrator\nDetails : " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        public void UpdatePopularity()
        {
            string qry = $"SELECT ItemID, Popularity FROM Product";
            SqlDataAdapter adapterIDs = new SqlDataAdapter(qry, con);
            DataTable tableIDs = new DataTable();
            adapterIDs.Fill(tableIDs);

            int numOfIds = tableIDs.Rows.Count;

 

            int[] IDarr = new int[numOfIds];

            for(int i = 0; i < numOfIds; i++)
            {
                IDarr[i] = (int)tableIDs.Rows[i][0];
            }

            

            foreach(int i in IDarr)
            {
                FillPopularity(i);
            }
            
        }
    }
}
