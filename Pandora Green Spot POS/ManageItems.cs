using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pandora_Green_Spot_POS
{
    public partial class ManageItems : Form
    {
        public ManageItems()
        {
            InitializeComponent();
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
    }
}
