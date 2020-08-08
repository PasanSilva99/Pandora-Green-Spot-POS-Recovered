using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Pandora_Green_Spot_POS
{
    public partial class ListItemManage : UserControl
    {
        public Image itemImage { get; set; } = Properties.Resources.manage;
        public string itemName { get; set; } = "Item Name";
        public string itemCategory { get; set; } = "Category";
        public double itemPrice { get; set; } = 0;
        public double popularity { get; set; } = 0;
        public int ItemID { get; set; }
        public string ImagePath { get; set; }

        

        public ListItemManage()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //Draw the graphic
            Graphics gr = e.Graphics;
            gr.SmoothingMode = SmoothingMode.AntiAlias;
            StringFormat PriceFormat = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            PriceFormat.LineAlignment = StringAlignment.Center;
            StringFormat popuFormat = new StringFormat();
            popuFormat.Alignment = StringAlignment.Center;
            popuFormat.LineAlignment = StringAlignment.Center;

            Font NameFont = new Font(this.Font.Name, 12);

            Rectangle ImageArea = new Rectangle(5, 5, this.Height - 10, this.Height - 10);
            Rectangle PriceRect = new Rectangle(0, 0, this.Width - 10, this.Height);

            gr.DrawImage(itemImage, ImageArea);
            gr.DrawString(itemName, NameFont, Brushes.Black, this.Height, 10);
            gr.DrawString(itemCategory, NameFont, Brushes.Black, this.Height + 15, 40);
            gr.DrawString("Popularity "+popularity.ToString()+"%", NameFont, Brushes.Black, PriceRect, popuFormat);
            gr.DrawString("Rs. " + itemPrice.ToString("F2"), NameFont, Brushes.Black, PriceRect, PriceFormat);
            gr.DrawLine(Pens.Gray, new PointF(0, this.Height - 1), new PointF(this.Width, this.Height - 1));
            //

        }
    }
}
