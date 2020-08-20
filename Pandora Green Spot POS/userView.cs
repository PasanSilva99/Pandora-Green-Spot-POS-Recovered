using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pandora_Green_Spot_POS
{
    public partial class userView : UserControl
    {
        public string UserName { get; set; } = "";
        public string Password { get; set; } = "";
        public string FirstName { get; set; } = "First Name";
        public string LastName { get; set; } = "Last Name";
        public string Address { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public string Priev { get; set; } = "User";
        public string Email { get; set; } = "";

        public userView()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Rectangle imgRect = new Rectangle(2, 2, this.Height - 2, this.Height - 2);

            Image img;

            if(Priev == "User")
            {
                img = Properties.Resources.user;
            }
            else
            {
                img = Properties.Resources.admin;
            }

            gr.DrawImage(img, imgRect);
            gr.DrawString(FirstName + "  " + LastName, new Font(this.Font.FontFamily, 10), Brushes.Black, new PointF(this.Height, 15));
            gr.DrawString(Priev, new Font(this.Font.FontFamily, 10), Brushes.Black, new PointF(this.Height + 10, 35));
            gr.DrawLine(Pens.LightGray, new PointF(0, this.Height - 1), new PointF(this.Width, this.Height - 1));
        }

    }
}
