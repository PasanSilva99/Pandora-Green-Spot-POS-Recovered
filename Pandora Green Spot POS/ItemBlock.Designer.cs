namespace Pandora_Green_Spot_POS
{
    partial class ItemBlock
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roundPanel1 = new Pandora_Green_Spot_POS.RoundPanel();
            this.ItemCategory = new System.Windows.Forms.Label();
            this.ItemName = new System.Windows.Forms.Label();
            this.ItemImage = new System.Windows.Forms.PictureBox();
            this.ItemPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1._BackColor = System.Drawing.Color.White;
            this.roundPanel1._BorderColor = System.Drawing.Color.Silver;
            this.roundPanel1._CornerRadius = 20F;
            this.roundPanel1._Shadow = true;
            this.roundPanel1.BackColor = System.Drawing.Color.White;
            this.roundPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(150, 150);
            this.roundPanel1.TabIndex = 0;
            // 
            // ItemCategory
            // 
            this.ItemCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemCategory.Location = new System.Drawing.Point(25, 13);
            this.ItemCategory.Name = "ItemCategory";
            this.ItemCategory.Size = new System.Drawing.Size(100, 18);
            this.ItemCategory.TabIndex = 1;
            this.ItemCategory.Text = "Category";
            this.ItemCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemName
            // 
            this.ItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemName.Location = new System.Drawing.Point(25, 117);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(100, 21);
            this.ItemName.TabIndex = 2;
            this.ItemName.Text = "Name";
            this.ItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemImage
            // 
            this.ItemImage.Location = new System.Drawing.Point(16, 33);
            this.ItemImage.Name = "ItemImage";
            this.ItemImage.Size = new System.Drawing.Size(120, 84);
            this.ItemImage.TabIndex = 3;
            this.ItemImage.TabStop = false;
            // 
            // ItemPrice
            // 
            this.ItemPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemPrice.BackColor = System.Drawing.Color.Transparent;
            this.ItemPrice.Location = new System.Drawing.Point(93, 117);
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Size = new System.Drawing.Size(37, 21);
            this.ItemPrice.TabIndex = 4;
            this.ItemPrice.Text = "Price";
            this.ItemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ItemBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ItemPrice);
            this.Controls.Add(this.ItemImage);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.ItemCategory);
            this.Controls.Add(this.roundPanel1);
            this.Name = "ItemBlock";
            ((System.ComponentModel.ISupportInitialize)(this.ItemImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ItemCategory;
        private System.Windows.Forms.Label ItemName;
        private System.Windows.Forms.PictureBox ItemImage;
        private System.Windows.Forms.Label ItemPrice;
        private RoundPanel roundPanel1;
    }
}
