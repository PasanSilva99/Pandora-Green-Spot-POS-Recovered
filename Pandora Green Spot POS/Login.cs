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
    public partial class Login : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\PandoraGreenSpot\Pandora.mdf;Integrated Security=True;Connect Timeout=30");
        public Login()
        {
            InitializeComponent();
            this.Refresh();
            MaskAdd(TB_UserName, "Enter UserName");
            MaskAdd(TB_Password, "Enter Password", true);
            TB_UserName.LostFocus += TB_UserName_LostFocus;
            TB_Password.LostFocus += TB_Password_LostFocus;
        }

        private void TB_Password_LostFocus(object sender, EventArgs e)
        {
            if (TB_Password.Text == "")
            MaskAdd(TB_Password, "Enter Password", true);
        }

        private void TB_UserName_LostFocus(object sender, EventArgs e)
        {
            if(TB_UserName.Text == "")
            MaskAdd(TB_UserName, "Enter UserName");
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customButton1_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(TB_UserName.Text != null && TB_UserName.Text != null)
            {
                String LoginCheck = "SELECT * FROM Employee WHERE userName = '" + TB_UserName.Text + "' AND password='" + TB_Password.Text + "' ";
                SqlDataAdapter LoginAdaptor = new SqlDataAdapter(LoginCheck, connection);
                DataTable userTb = new DataTable();
                LoginAdaptor.Fill(userTb);

                if(userTb.Rows.Count == 1)
                {
                    //Login Successfull
                    NewSale newSale = new NewSale();
                    newSale.Show();
                    this.Hide();
                }
                else
                {
                    //not a successfull login
                    MessageBox.Show("Not not not not");
                }
                
            }
            else
            {

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
            textBox.PasswordChar = '\0';
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
                MaskClear((sender as TextBox), true);
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
            textBox.PasswordChar = '•';
            textBox.Text = "";
            textBox.ForeColor = Color.Black;
        }


    }
}
