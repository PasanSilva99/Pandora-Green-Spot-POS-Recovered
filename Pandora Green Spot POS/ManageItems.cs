using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Pandora_Green_Spot_POS
{
    public partial class ManageItems : Form
    {
        //Created the SQL Connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\PandoraGreenSpot\Pandora.mdf;Integrated Security=True;Connect Timeout=30");

        //Set the default image path as Not Specified
        string selImgPath = "Not Specified";

        //This is the Directory for saving the image file
        //If there is no such directory, Code will automatically create a one.
        string imgdir = @"C:\PandoraGreenSpot\ItemImages";

        //Saved image path
        string savedpath = "";
        public ManageItems()
        {
            InitializeComponent();

            //List the items
            updateList();
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
            fillPictureBox(img_itemImage, (Bitmap)(sender as ListItemManage).itemImage);
        }

        /// <summary>
        /// This is the summary
        /// </summary>
        /// <param name="pbox">PictureBox Control Name</param>
        /// <param name="bmp">Bitmap Image</param>
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

            MemoryStream stream = new MemoryStream();
            img_itemImage.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] img = stream.ToArray();

            try
            {

                if (con.State == ConnectionState.Closed) con.Open();
                String qry = "UPDATE Product SET Product_name = @name, Category = @cat, Product_Price = @price, Image = @image, ImagePath = @path WHERE ItemID = @id";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@path", selImgPath);
                cmd.Parameters.AddWithValue("@image", img);
                cmd.Parameters.AddWithValue("@price", tb_itemPrice.Text);
                cmd.Parameters.AddWithValue("@cat", cb_itemCat.Text);
                cmd.Parameters.AddWithValue("@name", tb_itemName.Text);
                cmd.Parameters.AddWithValue("@id", int.Parse(lbl_id.Text));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            tb_itemName.Clear();
            img_itemImage.Image = null;
            cb_itemCat.Text = null;
            tb_itemPrice.Clear();
            selImgPath = "Not Specified";
            lbl_id.Text = "";
            updateList();

        }

        private void img_itemImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFile.Multiselect = false;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string url = openFile.FileName;
                fillPictureBox(img_itemImage, (Bitmap)Image.FromFile(url));
                if (!Directory.Exists(imgdir))
                {
                    Directory.CreateDirectory(imgdir);
                }
                string[] file = openFile.FileName.Split('.');
                savedpath = imgdir + @"/" + DateTime.Now.ToString("yyyyMMddhhss") + "." + file[file.Length - 1];
                File.Copy(url, savedpath, true);
                File.Delete(selImgPath);

            }
        }

        private void img_itemImage_MouseEnter(object sender, EventArgs e)
        {
            lbl_chText.Visible = true;
        }

        private void img_itemImage_MouseLeave(object sender, EventArgs e)
        {
            lbl_chText.Visible = false;
        }

        private void updateList()
        {
            itemArea.Controls.Clear();
            try
            {
                String qry = "Select Product_Name, Category, Product_Price, Image, ItemID , ImagePath FROM Product";
                SqlCommand cmd = new SqlCommand(qry, con);
                if (con.State == ConnectionState.Closed)
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
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void ManageItems_FormClosing(object sender, FormClosingEventArgs e)
        {
            // NewSale.;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string qry = $"DELETE FROM Product WHERE ItemID = {int.Parse(lbl_id.Text)}";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Success");
            }
            catch
            {

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                tb_itemName.Clear();
                img_itemImage.Image = null;
                cb_itemCat.Text = null;
                tb_itemPrice.Clear();
                selImgPath = "Not Specified";
                lbl_id.Text = "";
                updateList();

            }
        }
    }
}
