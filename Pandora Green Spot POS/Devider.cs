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

namespace Pandora_Green_Spot_POS
{
    public partial class Devider : UserControl
    {
        public Devider()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            gr.SmoothingMode = SmoothingMode.AntiAlias;

            Color shadow = Color.FromArgb(00, 16, 16, 16);
            for (int i = 0; i <10; i++)
            {
                using (Pen pen = new Pen(Color.FromArgb(00 + i * 2, shadow), 1.2f))
                    gr.DrawLine(pen, new PointF(0, this.Height / 2 + (10-i)), new PointF(this.Width, this.Height / 2 + (10-i)));
                
            }
            gr.DrawLine(new Pen(Color.LightGray), new PointF(0, this.Height / 2), new PointF(this.Width, this.Height / 2));

        }
    }
}
