using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Pandora_Green_Spot_POS 
{
    class GradientPanel : Panel
    {
        /// <summary>
        /// Color 1
        /// {get; set;} Add getters and setters - Shortcut
        /// Also i assigned a default value to it.
        /// </summary>
        public Color Color1 { get; set; } = Color.FromArgb(0, 87, 217);
        public Color Color2 { get; set; } = Color.FromArgb(71, 179, 0);

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            LinearGradientBrush brush = new LinearGradientBrush(new PointF(0,0), new PointF(Width,Height), Color1, Color2);
            gr.FillRectangle(brush, ClientRectangle);

        }
    }
}
