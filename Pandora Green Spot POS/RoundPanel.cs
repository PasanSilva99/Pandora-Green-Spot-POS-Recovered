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

namespace Pandora_Green_Spot_POS
{
    public partial class RoundPanel : UserControl
    {
        private Color _backColor = Color.White;
        private bool _shadow = true;
        private float _cornerRadius = 20;

        public float _CornerRadius
        {
            get
            {
                return _cornerRadius;
            }
            set
            {
                _cornerRadius = value;
                this.Invalidate();
            }
        }

        public Color _BackColor
        {
            get
            {
                return _backColor;
            }
            set
            {
                _backColor = value;
                this.Invalidate();
            }
        }

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

        public RoundPanel()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Color shadow = Color.FromArgb(00, 16, 16, 16);

            if (_shadow)
            {
                for (int i = 0; i < 10; i++)
                {
                    using (Pen pen = new Pen(Color.FromArgb(00 + i*2, shadow), 1.2f))

                        graphics.DrawRoundedRectangle(pen, this.ClientRectangle.X + i,
                                           this.ClientRectangle.Y + i, this.Width - i * 2, this.Height - i * 2, _cornerRadius);
                }
            }

            SolidBrush brush = new SolidBrush(_backColor);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.FillRoundedRectangle(brush, 10, 10, this.Width - 20, this.Height - 20, _cornerRadius);
            if(_BorderColor != null)
            graphics.DrawRoundedRectangle(new Pen(_BorderColor), 10, 10, this.Width - 20, this.Height - 20, _cornerRadius);

        }

    }
}
