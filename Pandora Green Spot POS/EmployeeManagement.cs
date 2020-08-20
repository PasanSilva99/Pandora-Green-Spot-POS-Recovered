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
    public partial class EmployeeManagement : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\PandoraGreenSpot\Pandora.mdf;Integrated Security=True;Connect Timeout=30");
        public EmployeeManagement()
        {
            InitializeComponent();
        }

        string userName;

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            EmployeeArea.Controls.Clear();
            string qry = "SELECT * From Employee";
            try
            {
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                
                while(sdr.Read())
                {
                    userView u = new userView();
                    u.UserName = sdr.GetValue(0).ToString().Replace(" ", "");
                    u.Password = sdr.GetValue(1).ToString().Replace(" ", "");
                    u.FirstName = sdr.GetValue(2).ToString().Replace(" ", "");
                    u.LastName = sdr.GetValue(3).ToString().Replace(" ", "");
                    u.Address = sdr.GetValue(4).ToString();
                    u.PhoneNumber = sdr.GetValue(5).ToString().Replace(" ", "");
                    u.Priev = sdr.GetValue(6).ToString().Replace(" ", "");
                    u.Email = sdr.GetValue(7).ToString().Replace(" ", "");

                    u.Click += User_Click;

                    EmployeeArea.Controls.Add(u);
                }
            }
            catch
            {

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void User_Click(object sender, EventArgs e)
        {
            userView user = sender as userView;

            userName = user.UserName;
            tb_userName.Text = userName;
            tb_firstName.Text = user.FirstName;
            tb_lastName.Text = user.LastName;
            tb_phone.Text = user.PhoneNumber;
            tb_mail.Text = user.Email;
            tb_address.Text = user.Address;
            cb_Priviladge.Text = user.Priev;

            tb_password.Text = user.Password;

            pnl_username._BackColor = Color.FromArgb(255, 224, 192);
            tb_userName.BackColor = Color.FromArgb(255, 224, 192);
            btn_save.ButtonText = "Save";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string qry;
            if (btn_save.ButtonText == "➕ Add")
            {
                qry = $"INSERT INTO [dbo].[Employee] " +
                $"([userName], [password], [FirstName], [LastName], [Address], [PhoneNumber], [PriviladgeLevel], [E-mail])" +
                $" VALUES (" +
                  $"'{tb_userName.Text}', " +
                  $"'{tb_password.Text}', " +
                  $"'{tb_firstName.Text}', " +
                  $"'{tb_lastName.Text}', " +
                  $"'{tb_address.Text}', " +
                  $"'{tb_password.Text}', " +
                  $"'{cb_Priviladge.Text}', " +
                  $"'{tb_mail.Text}')";
            }
            else
            {
                qry = $"UPDATE Employee SET " +
                    $"FirstName = '{tb_firstName.Text}', " +
                    $"LastName = '{tb_lastName.Text}', " +
                    $"Address = '{tb_address.Text}', " +
                    $"PhoneNumber = '{tb_phone.Text}', " +
                    $"PriviladgeLevel = '{cb_Priviladge.Text}', " +
                    $"[E-mail] = '{tb_mail.Text}' " +
                    $"WHERE userName = '{userName}'";
            }
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Updated Successfully", "Successfull");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Account Update Unsuccessfull. Contact Your IT Administrator \nDetails : " + ex.Message, "Error");
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();

                    }
                    LoadEmployees();
                }
            
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string qry = $"DELETE FROM Employee WHERE userName = '{userName}'";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Delete Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Remove Unsuccessfull. Contact Your IT Administrator \nDetails : " + ex.Message, "Error");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();

                }
                LoadEmployees();
            }
        }

        private void btn_addEmp_Click(object sender, EventArgs e)
        {
            pnl_username._BackColor = Color.White;
            tb_userName.BackColor = Color.White;
            btn_save.ButtonText = "➕ Add";
            

        }
    }
}
