using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Pandora_Green_Spot_POS
{
    public partial class AddProduct : Form
    {
        String imageUrl = null;
        string imgdir = @"C:\PandoraGreenSpot\ItemImages";
        string savedimagepath;

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\PandoraGreenSpot\Pandora.mdf;Integrated Security=True;Connect Timeout=30");

        public AddProduct()
        {
            InitializeComponent();
        }


        private void btn_picRemove_Click(object sender, EventArgs e)
        {
            imageUrl = null;
            img_pic.Image = null;
        }

        private void btn_picSave_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog() { Filter = "Image Files | *.jpg; *.jpeg; *.jpe; *.jfif; *.png" })
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    imageUrl = openFile.FileName;
                    fillPictureBox(img_pic, (Bitmap)Image.FromFile(openFile.FileName));
                    if (!Directory.Exists(imgdir))
                    {
                        Directory.CreateDirectory(imgdir);
                    }
                    string[] file = openFile.FileName.Split('.');
                    savedimagepath = imgdir + @"/" + DateTime.Now.ToString("yyyyMMddhhmmss") + "." + file[file.Length - 1];
                    File.Copy(imageUrl, savedimagepath, true);
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (img_pic.Image != null)
            {

                MemoryStream stream = new MemoryStream();
                img_pic.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] img = stream.ToArray();

                try
                {

                    if (connection.State == ConnectionState.Closed) connection.Open();
                    String qry = "INSERT INTO Product (Product_name, Category, Product_Price, Image, ImagePath) VALUES (@name, @cat, @price , @image, @path)";
                    SqlCommand cmd = new SqlCommand(qry, connection);
                    cmd.Parameters.AddWithValue("@path", savedimagepath);
                    cmd.Parameters.AddWithValue("@image", img);
                    cmd.Parameters.AddWithValue("@price", tb_price.Text);
                    cmd.Parameters.AddWithValue("@cat", cb_category.Text);
                    cmd.Parameters.AddWithValue("@name", tb_name.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Saved Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Image Null");
            }

            tb_name.Text = "";
            img_pic.Image = null;
            cb_category.Text = null;
            tb_price.Text = null;

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
            resized = null;
        }

    }
}
