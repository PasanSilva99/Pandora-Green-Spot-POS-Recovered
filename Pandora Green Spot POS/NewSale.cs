using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PointOFSalesSystem;
using System.Runtime.CompilerServices;
using System.Data.SqlTypes;

namespace Pandora_Green_Spot_POS
{
    public partial class NewSale : Form
    {
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\PandoraGreenSpot\Pandora.mdf;Integrated Security=True;Connect Timeout=30");
        int DiscountTodat = 0;
        long BillID = 0;
        int BillNum = 0;

        private readonly Random _random = new Random();
        public int RandomNumber()
        {
            return _random.Next(999);
        }
        public NewSale()
        {
            InitializeComponent();
            MaskAdd(TB_name, "Enter Item Name");
            MaskAdd(TB_price, "Enter Item Price");
            MaskAdd(TB_qty, "Qty");
            MaskAdd(TB_dis, "Discount");
            MaskAdd(TB_search, "Search Items");

            TB_search.GotFocus += TB_search_GotFocus;
            TB_search.LostFocus += TB_search_LostFocus;
            TB_name.GotFocus += TB_name_GotFocus;
            TB_price.GotFocus += TB_price_GotFocus;
            TB_qty.GotFocus += TB_qty_GotFocus;
            TB_dis.GotFocus += TB_dis_GotFocus;
            TB_name.LostFocus += TB_name_LostFocus;
            TB_price.LostFocus += TB_price_LostFocus;
            TB_qty.LostFocus += TB_qty_LostFocus;
            TB_dis.LostFocus += TB_dis_LostFocus;

            LoadList();
            
        }

        public void ReloadF()
        {
            this.Refresh();
        }
        int itemID;
        private void LoadList()
        {
            ItemArea.Controls.Clear();
            //Loding the available item the the item list view
            try
            {
                String qry = "Select Product_Name, Category, Product_Price, Image, ItemID FROM Product";
                SqlCommand cmd = new SqlCommand(qry, Connection);
                Connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    ItemView block = new ItemView();
                    block.ItemName = sdr.GetString(0);
                    block.ItemImage = Image.FromStream(sdr.GetStream(3));
                    block.BrandName = sdr.GetString(1);
                    block.itemPrice = sdr.GetString(2); //Change this
                    block.Width = 150;
                    block.Height = 150;
                    block._BorderColor = Color.LightGray;
                    block.ItemID = sdr.GetInt32(4);
                    block.Click += Block_Click;
                    block.MouseEnter += Block_MouseEnter;
                    block.MouseLeave += Block_MouseLeave;
                    ItemArea.Controls.Add(block);
                }

            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Connection.Close();
            }
        }

        private void Block_MouseLeave(object sender, EventArgs e)
        {
            (sender as ItemView)._Shadow = true;
        }

        private void Block_MouseEnter(object sender, EventArgs e)
        {
            (sender as ItemView)._Shadow = false;
        }
        int qty = 1;
        String cat = null;
        private void Block_Click(object sender, EventArgs e)
        {
            itemID = (sender as ItemView).ItemID;
            if (TB_name.Text == (sender as ItemView).ItemName && TB_price.Text == (sender as ItemView).itemPrice)
            {
                qty++;
            }
            else
            { 
                qty = 1;
            }
            MaskClear(TB_name);
            MaskClear(TB_price);
            MaskClear(TB_qty);
            MaskClear(TB_dis);
            TB_name.Text = (sender as ItemView).ItemName;
            TB_price.Text = (sender as ItemView).itemPrice;
            cat = (sender as ItemView).BrandName;
            TB_qty.Text = qty.ToString();
            TB_dis.Text = DiscountTodat.ToString();
        }

        private void TB_search_LostFocus(object sender, EventArgs e)
        {
            if (TB_search.Text == "")
            {
                MaskAdd(TB_search, "Search Items");
            }
        }

        private void TB_search_GotFocus(object sender, EventArgs e)
        {
            if (TB_search.Text == "Search Items") 
            {
                MaskClear(TB_search);
            }
        }

        private void TB_dis_LostFocus(object sender, EventArgs e)
        {
            if (TB_dis.Text == "")
            {
                MaskAdd(TB_dis, "Discount");
            }
        }

        private void TB_qty_LostFocus(object sender, EventArgs e)
        {
            if (TB_qty.Text == "")
            {
                MaskAdd(TB_qty, "Qty");
            }
        }

        private void TB_price_LostFocus(object sender, EventArgs e)
        {
            if (TB_price.Text == "")
            {
                MaskAdd(TB_price, "Enter Item Price");
            }
        }

        private void TB_name_LostFocus(object sender, EventArgs e)
        {
            if (TB_name.Text == "")
            {
                MaskAdd(TB_name, "Enter Item Name");
            }
        }

        private void TB_dis_GotFocus(object sender, EventArgs e)
        {
            if (TB_dis.Text == "Discount")
            {
                MaskClear(TB_dis);
            }
        }

        private void TB_qty_GotFocus(object sender, EventArgs e)
        {
            if (TB_qty.Text == "Qty")
            {
                MaskClear(TB_qty);
            }
        }

        private void TB_price_GotFocus(object sender, EventArgs e)
        {
            if (TB_price.Text == "Enter Item Price")
            {
                MaskClear(TB_price);
            }
        }

        private void TB_name_GotFocus(object sender, EventArgs e)
        {
            if (TB_name.Text == "Enter Item Name")
            {
                MaskClear(TB_name);
            } 

        }

        /// <summary>
        /// Open Login page when closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewSale_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundPanel7_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// For User Name Input Field
        /// </summary>
        /// <param name="textBox">TextBox Name</param>
        /// <param name="mask">Mask Displayed on the textbox</param>
        private void MaskAdd(TextBox textBox, String mask)
        {
            textBox.Text = mask;
            textBox.ForeColor = Color.Gray;
        }

        private void MaskClear(TextBox textBox)
        {
            textBox.Clear();
            textBox.ForeColor = Color.Black;
        }

        private void NewSale_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            rp_menu._Shadow = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            rp_menu._Shadow = false;
        }

        /// <summary>
        /// Expands or hides the navigation menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_ham_Click(object sender, EventArgs e)
        {
            if (navPanel.Width < 150)
            {
                //replace this part with a animation timer
                navPanel.Width = 150;
                navigation.CurrentPage = Navigation.Page.newSalePage;
                this.Width = this.Width + 150;

            }
            else
            {
                //replace this part with a animation timer
                navPanel.Width = 0;
                navigation.CurrentPage = Navigation.Page.newSalePage;
                this.Width = this.Width - 150;

            }
            
        }

        /// <summary>
        /// Image controls in pic box
        /// </summary>
        /// <param name="pbox"></param>
        /// <param name="bmp"></param>
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
        double billTotal = 0;
        /// <summary>
        /// Adds Items to the bill 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addToBill_Click(object sender, EventArgs e)
        {
            if(billArea.Controls.Count <1)
            {
                RefreshBill();
            }

            billItem bItem = new billItem();
            bItem.ItemName = TB_name.Text;
            bItem.ItemCat = cat;
            
            bItem.ItemPrice = TB_price.Text;
            bItem.ItemQty = TB_qty.Text;
            bItem.Size = new Size(245, 45);
            bItem.DoubleClick += BItem_DoubleClick;
            
            billArea.Controls.Add(bItem);
            this.ActiveControl = bItem;
            billArea.ScrollControlIntoView(bItem);

            //Add item to the bill
            try
            {
                String Qry = "INSERT INTO Bill (Bill_ID, ItemID , ItemName, ItemCategory, ItemDiscount, ItemPrice, Qty, Total, Date, Time) " +
                "VALUES (" +
                BillID +","+
                itemID + "," +
                "'" + TB_name.Text + "'," +
                "'" + cat + "'," +
                TB_dis.Text +","+
                TB_price.Text +","+
                TB_qty.Text +","+
                float.Parse(TB_qty.Text) * float.Parse(TB_price.Text) +
                ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                ",'" + DateTime.Now.ToString("hh:mm:ss") + "')";

                SqlCommand cmd = new SqlCommand(Qry, Connection);
                Connection.Open();
                cmd.ExecuteNonQuery();
                itemID = 0; 

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            CalculateTotal();

            ReportAnalysis analysis = new ReportAnalysis();
            analysis.UpdatePopularity();

            TB_dis.Clear();
            TB_name.Clear();
            TB_price.Clear();
            TB_qty.Clear();
            MaskAdd(TB_name, "Enter Item Name");
            MaskAdd(TB_price, "Enter Item Price");
            MaskAdd(TB_qty, "Qty");
            MaskAdd(TB_dis, "Discount");
            MaskAdd(TB_search, "Search Items");
        }

        private void CalculateTotal()
        {
            //calculate the total from the bill
            try
            {
                String qry = "SELECT SUM(Total) FROM Bill WHERE Bill_ID = '" + BillID + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(qry, Connection);
                DataTable vTable = new DataTable();
                dataAdapter.Fill(vTable);
                billTotal = Convert.ToDouble(vTable.Rows[0][0]);
                


            }
            catch (SqlNullValueException db)
            {
               
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error in Calculating Sum\n" + ex.Message);
                billTotal = 0;
            }
            finally
            {
                lbl_billTotal.Text = "Rs. " + billTotal.ToString("F2");
                if (Connection.State == ConnectionState.Open)
                    Connection.Close();
                cat = null;
            }
        }

        private void BItem_DoubleClick(object sender, EventArgs e)
        {
            string qry = $"DELETE FROM Bill WHERE ItemName = '{(sender as billItem).ItemName}' AND Total = '{(sender as billItem).ItemPrice}' AND Bill_Id = '{int.Parse(lbl_billID.Text)}'";
            SqlCommand cmd = new SqlCommand(qry, Connection);
            if(Connection.State == ConnectionState.Closed)
            Connection.Open();
            cmd.ExecuteNonQuery();
            if(Connection.State == ConnectionState.Open)
            Connection.Close();
            billArea.Controls.Remove((sender as billItem));
            CalculateTotal();
            if (billArea.Controls.Count == 0)
            {
                billTotal = 0;
                lbl_billTotal.Text = "Rs.  " + billTotal.ToString("F2");
            }
        }

        /// <summary>
        /// Genorates the bill ID
        /// </summary>
        private void RefreshBill()
        {
            BillNum++;  // Increase the bill number fro the session
            String newBillId = DateTime.Now.ToString("mmdd") + RandomNumber().ToString() + BillNum.ToString();  //  Genorate a bill ID
            BillID = Convert.ToInt64(newBillId); //Save the bill ID as a LONG
            lbl_billID.Text = newBillId;  // set the bill id text
            lbl_billDate.Text = DateTime.Now.ToString("dd-MM-yyyy");  // sets the date
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            // show the payment bill
            PayScreen pay = new PayScreen();
            pay.Total = billTotal;
            
            // if the payment compleate, reset the bill.
            if(pay.ShowDialog() == DialogResult.Yes)
            {
                BillID = 0;
                lbl_billTotal.Text = "0";
                lbl_finalDis.Text = "0";
                lbl_billID.Text = "0";
                billArea.Controls.Clear();
            }
        }

        private void btn_FruitJuice_Click(object sender, EventArgs e)
        {
            ItemArea.Controls.Clear();
            try
            {
                // the quary for selecting all available fruitjuices in the database.
                String qry = "Select Product_Name, Category, Product_Price, Image FROM Product WHERE Category = 'Fruit juice'";
                SqlCommand cmd = new SqlCommand(qry, Connection);
                if(Connection.State == ConnectionState.Closed) // if the connection state is close, open it.
                Connection.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    // Create a new control with ItemViewClass and set its prperties
                    ItemView block = new ItemView();
                    block.ItemName = sdr.GetString(0);
                    block.ItemImage = Image.FromStream(sdr.GetStream(3));
                    block.BrandName = sdr.GetString(1);
                    block.itemPrice = sdr.GetString(2); //Change this
                    block.Width = 150;
                    block.Height = 150;
                    block._BorderColor = Color.LightGray;
                    block.Click += Block_Click;
                    block.MouseEnter += Block_MouseEnter;
                    block.MouseLeave += Block_MouseLeave;
                    // add the created control to the ItemArea(FlowLayoutPanel)
                    ItemArea.Controls.Add(block);
                }

            }
            catch (Exception ex)
            {
                // if it catches an error, show it. 
                MessageBox.Show("Error loading fruit juices. Please ontact your IT Administrator \nDetails : " + ex.Message);
            }
            finally
            {
                if(Connection.State == ConnectionState.Open)
                Connection.Close();
            }
        }

        private void btn_milkShakes_Click(object sender, EventArgs e)
        {
            ItemArea.Controls.Clear();
            try
            {
                //The quary for load all the milkshakes avaliable
                String qry = "Select Product_Name, Category, Product_Price, Image FROM Product WHERE Category = 'Milkshake'";
                SqlCommand cmd = new SqlCommand(qry, Connection);
                //if the connection is closed, open the connection
                if(Connection.State == ConnectionState.Closed)
                    Connection.Open();

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    // create a new control by ItemView class and load it to the ItemArea(Flow layout pannel)
                    ItemView block = new ItemView();
                    block.ItemName = sdr.GetString(0);
                    block.ItemImage = Image.FromStream(sdr.GetStream(3));
                    block.BrandName = sdr.GetString(1);
                    block.itemPrice = sdr.GetString(2); //Change this
                    block.Width = 150;
                    block.Height = 150;
                    block._BorderColor = Color.LightGray;
                    block.Click += Block_Click;
                    block.MouseEnter += Block_MouseEnter;
                    block.MouseLeave += Block_MouseLeave;
                    // load the created control to the ItemArea(Flow Layout Panel)
                    ItemArea.Controls.Add(block);
                }

            }
            catch (Exception ex)
            {
                // if catches an error, show it.
                MessageBox.Show("Error loding milkshakes. Please contact your IT Administraor\nDetails : " + ex.Message);
            }
            finally
            {
                if(Connection.State == ConnectionState.Open)  // if the connection is open, closeit.
                Connection.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TB_search_TextChanged(object sender, EventArgs e)
        {
            if (TB_search.Text != null)
            {
                ItemArea.Controls.Clear();
                try
                {
                    //Quary for load data where the search match
                    String qry = $"Select Product_Name, Category, Product_Price, Image FROM Product WHERE Category LIKE '%{TB_search.Text}%' OR Product_Name LIKE '%{TB_search.Text}%' OR Product_Price LIKE '%{TB_search.Text}%'";
                    SqlCommand cmd = new SqlCommand(qry, Connection);
                    if(Connection.State == ConnectionState.Closed) Connection.Open();  // i conection isnot opened. open the connection
                    SqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())  // while sdr read the data
                    {
                        // create a ne control by a ItemView Class and set its properties. 
                        ItemView block = new ItemView();
                        block.ItemName = sdr.GetString(0);
                        block.ItemImage = Image.FromStream(sdr.GetStream(3));
                        block.BrandName = sdr.GetString(1);
                        block.itemPrice = sdr.GetString(2); //Change this
                        block.Width = 150;
                        block.Height = 150;
                        block._BorderColor = Color.LightGray;
                        block.Click += Block_Click;
                        block.MouseEnter += Block_MouseEnter;
                        block.MouseLeave += Block_MouseLeave;
                        //add the created control to the ItemArea(Flow layut panel)
                        ItemArea.Controls.Add(block);
                    }
                    sdr.Close(); //close the data reader.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error on loading the bill. Please contact your IT Administrator\nDetails : " + ex.Message); // if errep shoe the error message only
                }
                finally
                {
                    //if the connecton is open, close the connection.
                    if(Connection.State == ConnectionState.Open)Connection.Close();
                }
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private void billArea_ControlRemoved(object sender, ControlEventArgs e)
        {
            //if contraols falls to 0 reset the total.
            if(billArea.Controls.Count ==0)
            {
                billTotal = 0;
                lbl_billTotal.Text = "Rs.  " + billTotal.ToString("F2");
            }
        }

        private void billArea_MouseEnter(object sender, EventArgs e)
        {
            lbl_delete.Visible = true;
        }

        private void billArea_MouseLeave(object sender, EventArgs e)
        {
            lbl_delete.Visible = false;
        }
    }
}
