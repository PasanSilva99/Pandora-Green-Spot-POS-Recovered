using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using GraphicsExtention;

namespace PointOFSalesSystem
{
    public partial class ItemView : UserControl
    {
        private string _itemName = "Item Name";
        private string _brandName = "Brand Name";
        private Image _itemImage;
        private bool _shadow = true;
        private float _cornerRadius = 20;

        public String itemPrice{get; set;}
        

        public bool _Shadow
        {
            get
            {
                return _shadow;
            }
            set
            {
                _shadow = value;
                this.Invalidate();
            }
        }

        public Color _BorderColor { get; set; }
        public string BrandName
        {
            get
            {
                return _brandName;
            }
            set
            {
                _brandName = value;
                this.Invalidate();
            }
        }
        public Image ItemImage
        {
            get
            {
                return _itemImage;
            }
            set
            {
                _itemImage = value;
                this.Invalidate();
            }
        }
        public string ItemName
        {
            get
            {
                return _itemName;
            }
            set
            {
                _itemName = value;
                this.Invalidate();
            }
        }
        public ItemView()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            Rectangle rectangle = new Rectangle(2,this.Height - 30, this.Width - 4, 20);
            Rectangle rectBrand = new Rectangle(2, 12, this.Width - 10, 10);

            Color shadow = Color.FromArgb(00, 16, 16, 16);

            if (_shadow)
            {
                for (int i = 0; i < 10; i++)
                {
                    using (Pen pen = new Pen(Color.FromArgb(00 + i * 2, shadow), 1.2f))

                        g.DrawRoundedRectangle(pen, this.ClientRectangle.X + i,
                                           this.ClientRectangle.Y + i, this.Width - i * 2, this.Height - i * 2, _cornerRadius);
                }
            }
            g.DrawString(_brandName, this.Font, new SolidBrush(ForeColor), rectBrand, format);
            g.DrawImage(_itemImage, 15, 25, this.Width - 30, Height - 55);
            
            g.DrawString(_itemName, this.Font, new SolidBrush(ForeColor), rectangle, format);
            if (_BorderColor != null)
                g.DrawRoundedRectangle(new Pen(_BorderColor), 10, 10, this.Width - 20, this.Height - 20, _cornerRadius);
        }
    }
}
