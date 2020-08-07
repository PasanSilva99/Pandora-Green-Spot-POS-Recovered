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
    public partial class ManageItems : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\PandoraGreenSpot\Pandora.mdf;Integrated Security=True;Connect Timeout=30");

        public ManageItems()
        {
            InitializeComponent();
            //Calculations 
            try
            {
                String qry = "Select Product_Name, Category, Product_Price, Image FROM Product";
                SqlCommand cmd = new SqlCommand(qry, con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    ListItemManage item = new ListItemManage();
                    item.itemName = sdr.GetString(0);
                    item.itemCategory = sdr.GetString(1);
                    item.itemPrice = Convert.ToDouble(sdr.GetString(2));
                    item.itemImage = Image.FromStream(sdr.GetStream(3));
                    item.MouseClick += Item_MouseClick;
                    item.MouseEnter += Item_MouseEnter;
                    item.MouseLeave += Item_MouseLeave;
                    itemArea.Controls.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading the Items In to View. \nError : " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Item_MouseLeave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Item_MouseEnter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Item_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btn_printMenu_Click(object sender, EventArgs e)
        {
            printPreviewMenuDialog.Document = printMenuDoc;
            printPreviewMenuDialog.ShowDialog();
        }

        private void printMenuDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics gr = e.Graphics;


        }
    }
}
