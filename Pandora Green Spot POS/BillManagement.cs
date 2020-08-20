using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pandora_Green_Spot_POS
{
    public partial class BillManagement : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\PandoraGreenSpot\Pandora.mdf;Integrated Security=True;Connect Timeout=30");

        public BillManagement()
        {
            InitializeComponent();

            LoadBill();

            
        }

        private void LoadBill()
        {
            try
            {
                string qry = "SELECT * FROM Bill";
                SqlDataAdapter sda = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                billData.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                // If error
            }
            finally
            {
                // Lastly
            }

            
        }
        private void LoadBill(string date)
        {
            try
            {
                string qry = $"SELECT * FROM Bill WHERE Date = '{date}'";
                SqlDataAdapter sda = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                billData.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                // If error
            }
            finally
            {
                // Lastly
            }


        }

        private void btn_today_Click(object sender, EventArgs e)
        {
            LoadBill(DateTime.Now.ToString("MM-dd-yyyy"));
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadBill();
        }

        private void btn_drop_Click(object sender, EventArgs e)
        {
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string qry = "DELETE FROM Bill";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                LoadBill();
            }
            catch(Exception ex)
            {
                //If Error
                MessageBox.Show("Error Deleting Bill\nContact your IT Administrator\nDetails : 92SQDEL", "Error Deleting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
