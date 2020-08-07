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
    public partial class ItemBlock : UserControl
    {
        private String _Item_Category = "Category";
        private String _Item_Name = "Name";
        private String _Price = "Price";
        private Image _Image = null;

        public String Item_Category
        {
            get
            {
                return _Item_Category;
            }
            set
            {
                _Item_Category = value;
                ItemCategory.Text = _Item_Category;
                this.Invalidate();
            }
        }

        public String Item_Name
        {
            get
            {
                return _Item_Name;
            }
            set
            {
                _Item_Name = value;
                ItemName.Text = _Item_Name;
                this.Invalidate();
            }
        }
        public String Item_Price
        {
            get
            {
                return _Price;
            }
            set
            {
                _Price = value;
                ItemPrice.Text = _Price;
                this.Invalidate();
            }
        }
        public Image Item_Image
        {
            get
            {
                return _Image;
            }
            set
            {
                _Image = value;
                ItemImage.Image = _Image; 
                this.Invalidate();
            }
        }
        public ItemBlock()
        {
            InitializeComponent();
        }
    }
}
