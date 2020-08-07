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
    public partial class Navigation : UserControl
    {
        //enum - enumerations - you can access enum items with the dot syntax - reffer w3schools
        public enum Page
        {
            newSalePage,
            AddNewPage,
            ManageItemsPage,
            ReportsPage
        }

        public Page CurrentPage { get; set; }
        public Navigation()
        {
            InitializeComponent();

            #region Nav New Sale Events
            //mouse enter events for new sale nav item
            img_newSale.MouseEnter += Img_newSale_MouseEnter;
            lbl_newSale.MouseEnter += Lbl_newSale_MouseEnter;
            rp_newSale.MouseEnter += Rp_newSale_MouseEnter;

            //mouse leave events for ew sale nav item
            img_newSale.MouseLeave += Img_newSale_MouseLeave;
            lbl_newSale.MouseLeave += Lbl_newSale_MouseLeave;
            rp_newSale.MouseLeave += Rp_newSale_MouseLeave;

            //mouse click events for new sale nav item
            img_newSale.Click += Img_newSale_Click;
            lbl_newSale.Click += Lbl_newSale_Click;
            rp_newSale.Click += Rp_newSale_Click;
            #endregion

            #region Nav AddNew Events
            //mouse enter events for AddNew nav item
            img_AddNew.MouseEnter += Img_AddNew_MouseEnter;
            lbl_addNew.MouseEnter += Lbl_addNew_MouseEnter;
            rp_AddNew.MouseEnter += Rp_AddNew_MouseEnter;

            //mouse leave events for add new nav item
            img_AddNew.MouseLeave += Img_AddNew_MouseLeave;
            lbl_addNew.MouseLeave += Lbl_addNew_MouseLeave;
            rp_AddNew.MouseLeave += Rp_AddNew_MouseLeave;

            //mouse click events for add new nav item
            img_AddNew.Click += Img_AddNew_Click;
            lbl_addNew.Click += Lbl_addNew_Click;
            rp_AddNew.Click += Rp_AddNew_Click;
            #endregion

            #region Nav Reports Events
            // mouse enter events for Reports nav item
            img_reports.MouseEnter += Img_reports_MouseEnter;
            lbl_reports.MouseEnter += Lbl_reports_MouseEnter;
            rp_reports.MouseEnter += Rp_reports_MouseEnter;

            //mouse leave events for Reports Nav Item
            img_reports.MouseLeave += Img_reports_MouseLeave;
            lbl_reports.MouseLeave += Lbl_reports_MouseLeave;
            rp_reports.MouseLeave += Rp_reports_MouseLeave;

            //mouse click events for reports nav item
            img_reports.Click += Img_reports_Click;
            lbl_reports.Click += Lbl_reports_Click;
            rp_reports.Click += Rp_reports_Click;

            #endregion

            #region Nav Manage Events
            img_manage.Click += Img_manage_Click;
            #endregion
        }

        private void Img_manage_Click(object sender, EventArgs e)
        {
            ManageItems manage = new ManageItems();
            manage.Show();
        }


        #region Reports Nav Actions

        #region Mouse Click Reports
        private void Rp_reports_Click(object sender, EventArgs e)
        {
            if(CurrentPage == Page.ReportsPage)
            {
                //Youre in the reports page
            }
            else
            {
                Reports re = new Reports();
                re.StartPosition = FormStartPosition.CenterParent;
                re.Show();
            }
        }

        private void Lbl_reports_Click(object sender, EventArgs e)
        {
            Rp_reports_Click(this, new EventArgs());
        }

        private void Img_reports_Click(object sender, EventArgs e)
        {
            Rp_reports_Click(this, new EventArgs());
        }
        #endregion

        #region mouse leave reports nav
        private void Rp_reports_MouseLeave(object sender, EventArgs e)
        {
            rp_reports._Shadow = false;
        }

        private void Lbl_reports_MouseLeave(object sender, EventArgs e)
        {
            Rp_reports_MouseLeave(this, new EventArgs()); 
        }

        private void Img_reports_MouseLeave(object sender, EventArgs e)
        {
            Rp_reports_MouseLeave(this, new EventArgs());
        }
        #endregion

        #region mouse enter reports nav
        private void Rp_reports_MouseEnter(object sender, EventArgs e)
        {
            rp_reports._Shadow = true;
        }

        private void Lbl_reports_MouseEnter(object sender, EventArgs e)
        {
            Rp_reports_MouseEnter(this, new EventArgs());
        }

        private void Img_reports_MouseEnter(object sender, EventArgs e)
        {
            Rp_reports_MouseEnter(this, new EventArgs());
        }

        #endregion

        #endregion

        #region mouse click addnew
        private void Rp_AddNew_Click(object sender, EventArgs e)
        {
            //Validation Code
            if(CurrentPage == Page.AddNewPage)
            {
                //You re in this page
            }
            else
            {
                AddProduct addProduct = new AddProduct();
                addProduct.StartPosition = FormStartPosition.CenterParent;
                addProduct.Show();
                NewSale newSale = new NewSale();
            }
        }

        private void Lbl_addNew_Click(object sender, EventArgs e)
        {
            Rp_AddNew_Click(this, new EventArgs());
        }

        private void Img_AddNew_Click(object sender, EventArgs e)
        {
            Rp_AddNew_Click(this, new EventArgs());
        }
        #endregion

        #region mouse leave add new

        private void Rp_AddNew_MouseLeave(object sender, EventArgs e)
        {
            rp_AddNew._Shadow = false;
        }

        private void Lbl_addNew_MouseLeave(object sender, EventArgs e)
        {
            Rp_AddNew_MouseLeave(this, new EventArgs());
        }

        private void Img_AddNew_MouseLeave(object sender, EventArgs e)
        {
            Rp_AddNew_MouseLeave(this, new EventArgs());
        }
        #endregion

        #region mouse enter add new
        private void Rp_AddNew_MouseEnter(object sender, EventArgs e)
        {
            rp_AddNew._Shadow = true;
        }

        private void Lbl_addNew_MouseEnter(object sender, EventArgs e)
        {
            Rp_AddNew_MouseEnter(this, new EventArgs());
        }

        private void Img_AddNew_MouseEnter(object sender, EventArgs e)
        {
            Rp_AddNew_MouseEnter(this, new EventArgs());
        }
        #endregion

        #region Nav Item New Sale Actions

        #region mouse click new sale
        private void Rp_newSale_Click(object sender, EventArgs e)
        {
            if(CurrentPage == Page.newSalePage)
            {
                //You are in this page
            }
            else
            {
                //navigatin code
                NewSale newSale = new NewSale();
                newSale.Show();
                this.Width = 2;
            }
        }

        private void Lbl_newSale_Click(object sender, EventArgs e)
        {
            Rp_newSale_Click(this, new EventArgs());
        }

        private void Img_newSale_Click(object sender, EventArgs e)
        {
            Rp_newSale_Click(this, new EventArgs());
        }

        #endregion

        #region mouse leave new sale
        private void Rp_newSale_MouseLeave(object sender, EventArgs e)
        {
            rp_newSale._Shadow = false;

        }

        private void Lbl_newSale_MouseLeave(object sender, EventArgs e)
        {
            Rp_newSale_MouseLeave(this, new EventArgs());
        }

        private void Img_newSale_MouseLeave(object sender, EventArgs e)
        {
            Rp_newSale_MouseLeave(this, new EventArgs());
        }

        #endregion

        #region mouse enter new sale
        private void Rp_newSale_MouseEnter(object sender, EventArgs e)
        {
            rp_newSale._Shadow = true;
        }

        private void Lbl_newSale_MouseEnter(object sender, EventArgs e)
        {
            Rp_newSale_MouseEnter(this, new EventArgs());
        }

        private void Img_newSale_MouseEnter(object sender, EventArgs e)
        {
            Rp_newSale_MouseEnter(this, new EventArgs());

        }
        #endregion

        #endregion

        //Nav Item Add new Actions

    }
}