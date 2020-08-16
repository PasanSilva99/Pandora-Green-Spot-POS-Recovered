using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pandora_Green_Spot_POS
{
    //Pasan is crazy
    public partial class Login : Form
    {
        //creates the connection to the SQL Database
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\PandoraGreenSpot\Pandora.mdf;Integrated Security=True;Connect Timeout=30");
        //!Important 
        //Do not change the database location. 
        //Id there is no valid databse in "C:/PandoraGreenSpot/Pandora.mdf" & "C:/PandorGreenSpot/Pandora_log.ldf"
        //the program will show an error message telling there is a duplicate database of there is no such a database.
        public Login()
        {
            InitializeComponent();
            
            //Add masks to the textboxes. 
            MaskAdd(TB_UserName, "Enter UserName");
            MaskAdd(TB_Password, "Enter Password", true);
            TB_UserName.LostFocus += TB_UserName_LostFocus;
            TB_Password.LostFocus += TB_Password_LostFocus;
        }

        /// <summary>
        /// If the Password lost its focus
        /// and its text is null,
        /// this code will add the Default mask again.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TB_Password_LostFocus(object sender, EventArgs e)
        {
            if (TB_Password.Text == "")
            MaskAdd(TB_Password, "Enter Password", true);
        }

        /// <summary>
        /// if the usename textbox lost its focus
        /// and there is no any text insid it,
        /// this will add its default mask
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TB_UserName_LostFocus(object sender, EventArgs e)
        {
            if(TB_UserName.Text == "")
            MaskAdd(TB_UserName, "Enter UserName");
        }

        /// <summary>
        /// The cancel button
        /// To exit the applications
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customButton1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This function is to 
        /// Check weather the username and the passwords match and 
        /// if they match, login to the application
        /// if not show the message to the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_login_Click(object sender, EventArgs e)
        {
            //first check weather the input fields are not empoty
            if(TB_UserName.Text != null && TB_UserName.Text != null)
            {
                try
                {
                    //The sql quary for the validation
                    String LoginCheck = "SELECT * FROM Employee WHERE userName = '" + TB_UserName.Text + "' AND password='" + TB_Password.Text + "' ";
                    //Initialice the adaptor
                    SqlDataAdapter LoginAdaptor = new SqlDataAdapter(LoginCheck, connection);
                    //the virtul table for store the data
                    DataTable userTb = new DataTable();
                    //fill the tabe with fetched data.
                    //for a valid login thismust be only 1rows.
                    LoginAdaptor.Fill(userTb);

                    if (userTb.Rows.Count == 1)
                    {
                        //Login Successfull
                        NewSale newSale = new NewSale();
                        newSale.Show();
                        this.Hide();
                        Properties.Settings.Default.

                    }
                    else
                    {
                        //not a successfull login
                        MessageBox.Show("Incorrect UserName Or Password.\nIf you're not a registered user, Please use Gest Login or contact Administrator");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Login Error!\nContact Your IT Administrator\n Details : " + ex.Message, "Error");
                }

                
            }
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
            textBox.GotFocus += TextBox_GotFocus1;
        }

        /// <summary>
        /// For UserName Input Field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_GotFocus1(object sender, EventArgs e)
        {
            if((sender as TextBox).Text == "Enter UserName")
            MaskClear((sender as TextBox));
        }

        /// <summary>
        /// For Password Input field
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="mask"></param>
        /// <param name="psw"></param>
        private void MaskAdd(TextBox textBox, String mask, bool psw)
        {
            textBox.PasswordChar = '\0'; //Remove the Password charactor
            textBox.Text = mask;
            textBox.ForeColor = Color.Gray;
            textBox.GotFocus += TextBox_GotFocus;
        }

        /// <summary>
        /// For Password input field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "Enter Password")
                MaskClear((sender as TextBox), true); // this will clear the mask on the textbox and enable the password charactor. 

        }

        /// <summary>
        /// For UserName Imput Field
        /// </summary>
        /// <param name="textBox"></param>
        private void MaskClear(TextBox textBox)
        {
            textBox.Text = "";
            textBox.ForeColor = Color.Black;
        }

        /// <summary>
        /// For Password Input Field
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="psw"></param>
        private void MaskClear(TextBox textBox, bool psw)
        {
            textBox.PasswordChar = '•'; // enable the password charactor.
            textBox.Text = "";
            textBox.ForeColor = Color.Black; // Chane the text color.
        }


    }
}
