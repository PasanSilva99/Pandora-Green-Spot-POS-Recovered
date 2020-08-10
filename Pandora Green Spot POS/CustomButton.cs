using GraphicsExtention;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PointOfSalesSystem
{
    public partial class CustomButton : UserControl
    {
        private Color _defaultBackColor = Color.FromArgb(255, 255, 255);
        private Color _onOverBackColor = Color.FromArgb(230, 230, 230);
        private Color _onClickBackColor = Color.FromArgb(200, 200, 200);

        private Color _defaultForeColor = Color.FromArgb(0, 0, 0);
        private Color _onOverForeColor = Color.FromArgb(0, 0, 0);
        private Color _onClickForeColor = Color.FromArgb(0, 0, 0);

        private int _textSize;
        private string _buttonText = "Button";
        private Font _buttonFont = new Font("Century Gothic", 10);


        bool isOvering = false;
        bool isclicked = false;

        public Font ButtonFont
        {
            get
            {
                return _buttonFont;
            }
            set
            {
                _buttonFont = value;
                this.Invalidate();
            }
        }
        public string ButtonText
        {
            get
            {
                return _buttonText;
            }
            set
            {
                _buttonText = value;
                this.Invalidate();
            }
        }
        public int textSize
        {
            get
            {
                return _textSize;
            }
            set
            {
                _textSize = value;
                this.Invalidate();
            }
        }
        public Color onClickForeColor
        {
            get
            {
                return _onClickForeColor;
            }
            set
            {
                _onClickForeColor = value;
                this.Invalidate();
            }
        }
        public Color onOverForeColor
        {
            get
            {
                return _onOverForeColor;
            }
            set
            {
                _onOverForeColor = value;
                this.Invalidate();
            }
        }
        public Color defaultForeColor
        {
            get
            {
                return _defaultForeColor;
            }
            set
            {
                _defaultForeColor = value;
                this.Invalidate();
            }
        }
        public Color defaultBackColor
        {
            get
            {
                return _defaultBackColor;
            }
            set
            {
                _defaultBackColor = value;
                this.Invalidate();
            }
        }
        public Color onOverBackColor
        {
            get
            {
                return _onOverBackColor;
            }
            set
            {
                _onOverBackColor = value;
                this.Invalidate();
            }
        }
        public Color onClickBackColor
        {
            get
            {
                return _onClickBackColor;
            }
            set
            {
                _onClickBackColor = value;
                this.Invalidate(); 
            }
        }


        public CustomButton()
        {
            InitializeComponent();
             
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            SolidBrush brush = new SolidBrush(_defaultBackColor);
            Rectangle rectangle = new Rectangle(5, 5, this.Width - 15, this.Height - 15);

            if (isOvering)
            {
                if (isclicked)
                {
                    graphics.FillRoundedRectangle(new SolidBrush(_onClickBackColor), 5, 5, this.Width - 15, this.Height - 15, 20);
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;
                    graphics.DrawString(_buttonText, _buttonFont, new SolidBrush(_onClickForeColor), rectangle, stringFormat);
                }
                else
                {
                    graphics.FillRoundedRectangle(new SolidBrush(_onOverBackColor), 5, 5, this.Width - 15, this.Height - 15, 20);
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;
                    graphics.DrawString(_buttonText, _buttonFont, new SolidBrush(_onOverForeColor), rectangle, stringFormat);
                }
            }
            else
            {
                graphics.FillRoundedRectangle(new SolidBrush(_defaultBackColor), 5, 5, this.Width - 15, this.Height - 15, 20);
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                graphics.DrawString(_buttonText, _buttonFont, new SolidBrush(_defaultForeColor), rectangle, stringFormat);
            }
            brush.Dispose();

        }

        private void CustomButton_MouseEnter(object sender, System.EventArgs e)
        {
            isOvering = true;
            this.Invalidate();
        }

        private void CustomButton_MouseLeave(object sender, System.EventArgs e)
        {
            isOvering = false;
            this.Invalidate();
        }

        private void CustomButton_MouseDown(object sender, MouseEventArgs e)
        {
            isclicked = true;
            this.Invalidate();
        }

        private void CustomButton_MouseUp(object sender, MouseEventArgs e)
        {
            isclicked = false;
            this.Invalidate();
        }
    }
}
