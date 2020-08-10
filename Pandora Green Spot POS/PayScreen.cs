using System;
using System.Windows.Forms;


namespace Pandora_Green_Spot_POS
{
    public partial class PayScreen : Form
    {
        public Double Total { get; set; }
        public PayScreen()
        {
            InitializeComponent();

        }

        private void PayScreen_Load(object sender, EventArgs e)
        {
            lbl_totalBill.Text = Total.ToString("F2");
        }

        private void tb_cusCash_TextChanged(object sender, EventArgs e)
        {
            double balance = Double.Parse(tb_cusCash.Text) - Total;
            lbl_balance.Text = balance.ToString("F2");
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
