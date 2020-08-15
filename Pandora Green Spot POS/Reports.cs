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
    public partial class Reports : Form
    {
        // creates the sql connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\PandoraGreenSpot\Pandora.mdf;Integrated Security=True;Connect Timeout=30");

        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // calling the calculators.
            // these calculator functions will fill the charts and lables by its calculated values.
            // !important. - Some error messages are dissable because the user might need not to see those popups time to time. 
            // Insted we can inform them if here is any problem occuring inform us
            // Errors that can get here will not affect the overoll program. 
            // Errors are just cant fill or read will appear. 
            // When debugging remember to uncomment the error messages inside the exception handing. 
            FillRevenue(); 
            FillTopSales();  
            CalculateTodaysTotal();
            CalculateMonthlySales();
            CalculateWeekSales();
            CalculateYearlySales();
        }

        private void FillRevenue()
        {
            try
            {
                string currentMonth = DateTime.Now.ToString("MM");   // saves the current month to a variable
                string currentYear = DateTime.Now.ToString("yyyy");  // saves the current year to a variable 
                string qry = "SELECT Total, Date FROM Bill";         // select query 
                if (con.State == ConnectionState.Closed)             // if connection is closed 
                    con.Open();  // open the connection
                SqlCommand cmd = new SqlCommand(qry, con);           // initialize the command
                SqlDataReader sdr = cmd.ExecuteReader();             // execute the data reader

                int i = 0;          // the index for x-axis of revenue chart 
                while (sdr.Read())  // while data reader is reading data
                {
                    i++;  // increase the index by one
                    chart_rev.Series["Monthly"].Points.AddXY(Convert.ToDouble(i), sdr.GetDouble(0));  // add a new point to revenue chart
                    //  syntax: chartname.Series["SeriesName"].Points.AddXY(double x, double y) 
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error Calculating Revenue\nDetails : " + ex.Message, "Error Loading Revenue");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        private void FillTopSales()
        {
            try
            {
                //get sold items ascending order to calculate duplicates
                string qry = $"SELECT ItemID, ItemName, Qty FROM Bill ORDER BY ItemID ASC";
                SqlDataAdapter RepatQtyCAd = new SqlDataAdapter(qry, con);  //  initialize the data adaptor
                DataTable RepeatCheckTb = new DataTable();                  // create a virtual table for existing items in the bill table
                RepatQtyCAd.Fill(RepeatCheckTb);                            // fill the data table with fetched data

                int rowsCount = RepeatCheckTb.Rows.Count;  // get the number of rows

                DataTable ModTb = new DataTable();  // create a virtual table for get he total sum ofsold quantities
                ModTb.Columns.Add("ItemID");        // add a new column as to store the item id 
                ModTb.Columns.Add("Qty");           // add a new coulum to store the total quantity
                ModTb.Columns.Add("ItemName");
                for(int r = 1; r<rowsCount; r++)    // until the rows available this loop will run
                {
                    int itemID = (int)RepeatCheckTb.Rows[r-1]["itemID"];  // select an item id to find dupicates
                    int itemQty = (int)RepeatCheckTb.Rows[r-1]["Qty"];    // the selected item id quantity
                    string itemName = (string)RepeatCheckTb.Rows[r - 1]["itemName"];

                    // search through whole table for duplicates
                    for (int i = 1; i < rowsCount; i++)  
                    {
                        if(itemID == (int)RepeatCheckTb.Rows[i]["ItemID"])  // if the next rowm of the table contains same index(the table is organized in ascending order)
                        {
                            itemQty = itemQty + (int)RepeatCheckTb.Rows[i]["Qty"];  // if it is the same ids add the quantities together 
                            r++;  // skip this row because this is a duplicated row
                        }
                    }
                    ModTb.Rows.Add(itemID, itemQty, itemName);  // fill the row with modified values
                   // dataGridView1.DataSource = ModTb.DefaultView;  // remove this after debugging    
                }

                //This code part is to fill the chart with the top 5 items.
                int row = ModTb.Rows.Count-1;  // Get the last row
                int count = 0;                 // The counter

                ModTb.DefaultView.Sort = "Qty ASC";  // Order the table as Ascending
                ModTb = ModTb.DefaultView.ToTable(); // Default vies as the updated ordere dtab;e

                while (row >= 0) //Stop if Row count gets 0
                {
                    count++;
                    chart_topSelling.Series["TopSales"].Points.AddXY(ModTb.Rows[row][2], ModTb.Rows[row][1]);
                    row--;
                    if (count == 5) break;
                }

                



            }
            catch (Exception ex)
            {
               // MessageBox.Show("Error Calculating TopSelling\nDetails : " + ex.Message, "Error Loading Revenue");
            }
            finally
            {
                if (con.State == ConnectionState.Open)  // if the connection is open
                    con.Close();                        // close the connection
            }
        }

        private void CalculateTodaysTotal()
        {
            double total = 0.00;

            try
            {
                
                string currentDate = DateTime.Now.ToString("MM-dd-yyyy");                  // saves the current date to a variable
                string qry = $"SELECT SUM(Total) FROM Bill WHERE Date = '{currentDate}'";  // select query 
                if (con.State == ConnectionState.Closed)  // if connection is closed 
                    con.Open();  
                SqlDataAdapter AdaptorSUM = new SqlDataAdapter(qry, con);  //  initialize the data adaptor
                DataTable TodaySumTb = new DataTable();                    // create a virtual table for Todays Total Sum
                AdaptorSUM.Fill(TodaySumTb);                               // fill the data table with fetched data

                if(TodaySumTb.Rows.Count != 0) //If it is not null
                    total = (double)TodaySumTb.Rows[0][0]; // Update total
            } 
            catch(Exception ex)
            {
                //MessageBox.Show("Error Calculating Todays Total\nDetails : " + ex.ToString(), "Error Loading Data");
            }
            finally
            {
                lbl_todaySale.Text = "Rs. " + total.ToString("F2");
            }
        }

        private void CalculateMonthlySales()
        {
            double total = 0.00;

            try
            {
                string currentMonth = DateTime.Now.ToString("MM");  
                string currentYear = DateTime.Now.ToString("yyyy");
                string qry = $"SELECT SUM(Total) FROM Bill WHERE Date LIKE '%{currentYear}%{currentMonth}%'"; 
                SqlDataAdapter AdaptorSUM = new SqlDataAdapter(qry, con); 
                DataTable MonthSumTb = new DataTable();  // create a virtual table for Sum of 30 days of sales
                AdaptorSUM.Fill(MonthSumTb);  

                total = (double)MonthSumTb.Rows[0][0];
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            finally
            {
                lbl_monthSale.Text = "Rs. " + total.ToString("F2");
            }
        }

        private void CalculateWeekSales()
        {
            double total = 0.00;

            try
            {
                string currentDate = DateTime.Now.ToString("MM-dd-yyyy");  // saves the current date to a variable
                string WeekBefore = DateTime.Now.AddDays(-7).ToString("MM-dd-yyyy");
                string qry = $"SELECT SUM(Total) FROM Bill WHERE Date BETWEEN '{WeekBefore}' AND '{currentDate}'";  
                SqlDataAdapter AdaptorSUM = new SqlDataAdapter(qry, con);  
                DataTable WeekSumTb = new DataTable();  
                AdaptorSUM.Fill(WeekSumTb);  

                total = (double)WeekSumTb.Rows[0][0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            finally
            {
                lbl_weekSale.Text = "Rs. " + total.ToString("F2");
            }
        }

        private void CalculateYearlySales()
        {
            double total = 0.00;

            try
            {
                string currentDate= DateTime.Now.ToString("MM-dd-yyyy");  // saves the current date to a variable
                string YearBefore = DateTime.Now.AddDays(-365).ToString("MM-dd-yyyy");
                string qry = $"SELECT SUM(Total) FROM Bill WHERE Date BETWEEN '{YearBefore}' AND '{currentDate}'";   
                SqlDataAdapter AdaptorSUM = new SqlDataAdapter(qry, con);  
                DataTable YearSumTb = new DataTable();  // create a virtual table for total sales within 365 days
                AdaptorSUM.Fill(YearSumTb);  // fill the data table with fetched data

                total = (double)YearSumTb.Rows[0][0];
               
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            finally
            {
                lbl_yearSale.Text = "Rs. " + total.ToString("F2");
            }
        }


    }
}
