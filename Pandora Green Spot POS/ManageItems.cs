using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Pandora_Green_Spot_POS
{
    public partial class ManageItems : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\PandoraGreenSpot\Pandora.mdf;Integrated Security=True;Connect Timeout=30");

        //Save the selected image path
        string imagePath;

        //The directory where the img saved
        string imgDir = @"C:/PandoraGreenSpot/ItemImages";

        //the selected image path will save to this 
        string savedPath = "Not Specified";
        
        public ManageItems()
        {
            InitializeComponent();

            //List All the Items
            updateList();

            //Imagebox Events
            img_itemImage.MouseEnter += Img_itemImage_MouseEnter;
            img_itemImage.MouseLeave += Img_itemImage_MouseLeave;
            img_itemImage.Click += Img_itemImage_Click;

            //SaveButtonClick
            btn_save.Click += Btn_save_Click;

            //Delete Button Click
            btn_delete.Click += Btn_delete_Click;
        }

        private void Btn_delete_Click(object sender, EventArgs e)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                tb_itemName.Clear();
                img_itemImage.Image = null;
                cb_itemCat.Text = null;
                tb_itemPrice.Clear();
                imagePath = "Not Specified";
                lbl_id.Text = "";
                updateList();

            }
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            img_itemImage.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] img = stream.ToArray();

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string qry =
                    "UPDATE " +
                        "Product " +
                    "SET " +
                        "Product_name = @name, " +
                        "Category = @cat, " +
                        "Product_price = @price, " +
                        "Image = @image, " +
                        "ImagePath = @path " +
                    "WHERE " +
                        "ItemID = @id";

                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", tb_itemName.Text);
                cmd.Parameters.AddWithValue("@cat", cb_itemCat.Text);
                cmd.Parameters.AddWithValue("@price", tb_itemPrice.Text);
                cmd.Parameters.AddWithValue("@image", img);
                cmd.Parameters.AddWithValue("@path", savedPath);
                cmd.Parameters.AddWithValue("@id", int.Parse(lbl_id.Text));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                tb_itemName.Clear();
                img_itemImage.Image = null;
                cb_itemCat.Text = null;
                tb_itemPrice.Clear();
                imagePath = "Not Specified";
                lbl_id.Text = "";
                updateList();
            }
        }


        /// <summary>
        /// when click on the image image should be able to change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Img_itemImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            fileDialog.Multiselect = false;

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                string url = fileDialog.FileName;
                fillPictureBox(img_itemImage, (Bitmap)Image.FromFile(url));
                if(!Directory.Exists(imgDir))
                {
                    Directory.CreateDirectory(imgDir);
                }

                string[] file = url.Split('.');
                savedPath = imgDir + @"/" + DateTime.Now.ToString("yyyyMMddss") + "." + file[file.Length - 1];
                File.Copy(url, savedPath, true);
                File.Delete(imagePath);
            }
        }

        /// <summary>
        /// Hides the "CLick to change the image" when mouse leave
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Img_itemImage_MouseLeave(object sender, EventArgs e)
        {
            lbl_chText.Visible = false;
        }


        /// <summary>
        /// When mouse enters "Click to change Image" Will appear.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Img_itemImage_MouseEnter(object sender, EventArgs e)
        {
            lbl_chText.Visible = true;
        }

        private void ManageItems_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Update new sales

        }

        

        

        /// <summary>
        /// Update the item list
        /// </summary>
        private void updateList()
        {
            //clear all the ites in the list
            itemArea.Controls.Clear();

            try
            {
                //The sql quary for selecting the item details
                string ListUpdateQry = 
                    "SELECT " +
                        "ItemID," + //0
                        "Product_Name, " + //1
                        "Category, " + //2
                        "Product_price," + //3
                        "Image," + //4
                        "ImagePath, " + //5
                        "Popularity " + //6
                    "FROM " +
                        "Product";
                SqlCommand cmd = new SqlCommand(ListUpdateQry, con);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    ListItemManage ListItem = new ListItemManage();
                    ListItem.ItemID = sdr.GetInt32(0);
                    ListItem.itemName = sdr.GetString(1);
                    ListItem.itemCategory = sdr.GetString(2);
                    ListItem.itemPrice = Convert.ToDouble(sdr.GetString(3));
                    ListItem.itemImage = Image.FromStream(sdr.GetStream(4));
                    ListItem.ImagePath = sdr.GetString(5);
                    ListItem.popularity = Convert.ToDouble(sdr.GetString(6));
                    ListItem.MouseClick += ListItem_MouseClick;
                    ListItem.MouseEnter += ListItem_MouseEnter;
                    ListItem.MouseLeave += ListItem_MouseLeave;

                    //Add the configured control to the Item View Control
                    itemArea.Controls.Add(ListItem);

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        /// <summary>
        /// Just a UI Effect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListItem_MouseLeave(object sender, EventArgs e)
        {
            //When mouse leave reset the Bg
            (sender as ListItemManage).BackColor = Color.White;
        }
        /// <summary>
        /// Just a UI Effect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListItem_MouseEnter(object sender, EventArgs e)
        {
            //WHen mouse enter the item view change the back color,
            (sender as ListItemManage).BackColor = Color.LightGray;
        }

        /// <summary>
        /// When clicked on a list item
        /// This function will load the item properties 
        /// to the property pannel 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListItem_MouseClick(object sender, MouseEventArgs e)
        {
            //Clicked on the Item on the list.
            //When clicked add to the Item Properties pane.
            tb_itemName.Text = (sender as ListItemManage).itemName;
            cb_itemCat.Text = (sender as ListItemManage).itemCategory;
            tb_itemPrice.Text = (sender as ListItemManage).itemPrice.ToString("F2");
            lbl_id.Text = (sender as ListItemManage).ItemID.ToString();
            imagePath = (sender as ListItemManage).ImagePath;
            fillPictureBox(img_itemImage, (Bitmap)(sender as ListItemManage).itemImage);
        }


        /// <summary>
        /// Fills the picture in to the picturebox
        /// </summary>
        /// <param name="pbox">The picturebox name</param>
        /// <param name="bmp">Image as a bitmap</param>
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
            resized = null;
        }
    }
}


