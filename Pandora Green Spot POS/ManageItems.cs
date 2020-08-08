using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pandora_Green_Spot_POS
{
    public partial class ManageItems : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\PandoraGreenSpot\Pandora.mdf;Integrated Security=True;Connect Timeout=30");
        int SelectedItemId = 0;

        string selImgPath;
        byte[] imgbb;
        public ManageItems()
        {
            InitializeComponent();
            //Calculations 
            try
            {
                String qry = "Select Product_Name, Category, Product_Price, Image, ItemID , ImagePath FROM Product";
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
                    item.ItemID = sdr.GetInt32(4);
                    item.MouseClick += Item_MouseClick;
                    item.MouseEnter += Item_MouseEnter;
                    item.MouseLeave += Item_MouseLeave;
                    item.ImagePath = sdr.GetString(5);
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
            (sender as ListItemManage).BackColor = Color.White;
        }

        private void Item_MouseEnter(object sender, EventArgs e)
        {
            (sender as ListItemManage).BackColor = Color.LightGray;
        }

        private void Item_MouseClick(object sender, MouseEventArgs e)
        {
            tb_itemName.Text = (sender as ListItemManage).itemName;
            cb_itemCat.SelectedItem = (sender as ListItemManage).itemCategory;
            tb_itemPrice.Text = (sender as ListItemManage).itemPrice.ToString("F2");
            lbl_id.Text = (sender as ListItemManage).ItemID.ToString();
            selImgPath = (sender as ListItemManage).ImagePath;
            fillPictureBox(img_itemImage,(Bitmap)(sender as ListItemManage).itemImage);
        }

        static public void fillPictureBox(PictureBox pbox, Bitmap bmp)
        {
            pbox.SizeMode = PictureBoxSizeMode.Normal;
            bool source_is_wider = (float)bmp.Width / bmp.Height > (float)pbox.Width / pbox.Height;

            var resized = new Bitmap(pbox.Width, pbox.Height);
            var g = Graphics.FromImage(resized);
            var dest_rect = new Rectangle(0, 0, pbox.Width, pbox.Height);
            Rectangle src_rect;

            if (source_is_wider)
            {
                float size_ratio = (float)pbox.Height / bmp.Height;
                int sample_width = (int)(pbox.Width / size_ratio);
                src_rect = new Rectangle((bmp.Width - sample_width) / 2, 0, sample_width, bmp.Height);
            }
            else
            {
                float size_ratio = (float)pbox.Width / bmp.Width;
                int sample_height = (int)(pbox.Height / size_ratio);
                src_rect = new Rectangle(0, (bmp.Height - sample_height) / 2, bmp.Width, sample_height);
            }

            g.DrawImage(bmp, dest_rect, src_rect, GraphicsUnit.Pixel);
            g.Dispose();

            pbox.Image = resized;
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            
            try
            {

                byte[] image = null;
                FileStream stream = new FileStream(selImgPath, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                image = brs.ReadBytes((int)stream.Length);

                if (con.State == ConnectionState.Closed) con.Open();
                string qry = "Update Product " +
                    "SET Product_Name = '" + tb_itemName.Text + "'," +
                    "Category = '" + cb_itemCat.Text + "'," +
                    "Product_price = '" + tb_itemPrice.Text + "'," +
                    "Image = '" + image + "'" +
                    "WHERE ItemID = " + int.Parse(lbl_id.Text);

                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Saving Error \nError details : " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }
    }
}
