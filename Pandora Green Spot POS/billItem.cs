using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Drawing.Drawing2D;

namespace Pandora_Green_Spot_POS
{
    public partial class billItem : UserControl
    {
        public String ItemName { get; set; } = "Item Name";
        public String ItemCat { get; set; } = "Category";
        public String ItemQty { get; set; } = "Qty";
        public String ItemPrice { get; set; } = "0";

        public billItem()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Double fPrice = Convert.ToDouble(ItemPrice);
            Rectangle priceRect = new Rectangle(0, 20, this.Width - 3, 15);
            StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            Graphics gr = e.Graphics;
            gr.SmoothingMode = SmoothingMode.AntiAlias;
            gr.DrawString(ItemCat, this.Font, new SolidBrush(this.ForeColor), new PointF(3, 3));
            gr.DrawString(ItemName, this.Font, new SolidBrush(this.ForeColor), new PointF(5, 20));
            gr.DrawString("Qty "+ItemQty+"    Rs. "+(fPrice*Convert.ToInt32(ItemQty)).ToString("F2"), this.Font, new SolidBrush(this.ForeColor), priceRect, format);
        }
    }
}
