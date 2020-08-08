namespace Pandora_Green_Spot_POS
{
    partial class ManageItems
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageItems));
            this.printMenuDoc = new System.Drawing.Printing.PrintDocument();
            this.printPreviewMenuDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gradientPanel1 = new Pandora_Green_Spot_POS.GradientPanel();
            this.lbl_id = new System.Windows.Forms.Label();
            this.img_itemImage = new System.Windows.Forms.PictureBox();
            this.cb_itemCat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_itemPrice = new System.Windows.Forms.TextBox();
            this.tb_itemName = new System.Windows.Forms.TextBox();
            this.btn_save = new PointOfSalesSystem.CustomButton();
            this.btn_delete = new PointOfSalesSystem.CustomButton();
            this.roundPanel6 = new Pandora_Green_Spot_POS.RoundPanel();
            this.roundPanel5 = new Pandora_Green_Spot_POS.RoundPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.roundPanel4 = new Pandora_Green_Spot_POS.RoundPanel();
            this.roundPanel3 = new Pandora_Green_Spot_POS.RoundPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_printMenu = new PointOfSalesSystem.CustomButton();
            this.itemArea = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.devider2 = new Pandora_Green_Spot_POS.Devider();
            this.devider1 = new Pandora_Green_Spot_POS.Devider();
            this.roundPanel2 = new Pandora_Green_Spot_POS.RoundPanel();
            this.roundPanel1 = new Pandora_Green_Spot_POS.RoundPanel();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_itemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // printMenuDoc
            // 
            this.printMenuDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printMenuDoc_PrintPage);
            // 
            // printPreviewMenuDialog
            // 
            this.printPreviewMenuDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewMenuDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewMenuDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewMenuDialog.Enabled = true;
            this.printPreviewMenuDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewMenuDialog.Icon")));
            this.printPreviewMenuDialog.Name = "printPreviewMenuDialog";
            this.printPreviewMenuDialog.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(217)))));
            this.gradientPanel1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.gradientPanel1.Controls.Add(this.lbl_id);
            this.gradientPanel1.Controls.Add(this.img_itemImage);
            this.gradientPanel1.Controls.Add(this.cb_itemCat);
            this.gradientPanel1.Controls.Add(this.label7);
            this.gradientPanel1.Controls.Add(this.label6);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.tb_itemPrice);
            this.gradientPanel1.Controls.Add(this.tb_itemName);
            this.gradientPanel1.Controls.Add(this.btn_save);
            this.gradientPanel1.Controls.Add(this.btn_delete);
            this.gradientPanel1.Controls.Add(this.roundPanel6);
            this.gradientPanel1.Controls.Add(this.roundPanel5);
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.roundPanel4);
            this.gradientPanel1.Controls.Add(this.roundPanel3);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.btn_printMenu);
            this.gradientPanel1.Controls.Add(this.itemArea);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.devider2);
            this.gradientPanel1.Controls.Add(this.devider1);
            this.gradientPanel1.Controls.Add(this.roundPanel2);
            this.gradientPanel1.Controls.Add(this.roundPanel1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1047, 618);
            this.gradientPanel1.TabIndex = 0;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.White;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(979, 100);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 16);
            this.lbl_id.TabIndex = 23;
            this.lbl_id.Text = "ID";
            // 
            // img_itemImage
            // 
            this.img_itemImage.Location = new System.Drawing.Point(766, 337);
            this.img_itemImage.Name = "img_itemImage";
            this.img_itemImage.Size = new System.Drawing.Size(240, 185);
            this.img_itemImage.TabIndex = 22;
            this.img_itemImage.TabStop = false;
            // 
            // cb_itemCat
            // 
            this.cb_itemCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_itemCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_itemCat.FormattingEnabled = true;
            this.cb_itemCat.Items.AddRange(new object[] {
            "Fruit juice",
            "Milkshake",
            "Other"});
            this.cb_itemCat.Location = new System.Drawing.Point(770, 198);
            this.cb_itemCat.Name = "cb_itemCat";
            this.cb_itemCat.Size = new System.Drawing.Size(233, 24);
            this.cb_itemCat.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(779, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Rs. ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(745, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(745, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Category";
            // 
            // tb_itemPrice
            // 
            this.tb_itemPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_itemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_itemPrice.Location = new System.Drawing.Point(819, 270);
            this.tb_itemPrice.Name = "tb_itemPrice";
            this.tb_itemPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_itemPrice.Size = new System.Drawing.Size(184, 19);
            this.tb_itemPrice.TabIndex = 19;
            // 
            // tb_itemName
            // 
            this.tb_itemName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_itemName.Location = new System.Drawing.Point(767, 132);
            this.tb_itemName.Name = "tb_itemName";
            this.tb_itemName.Size = new System.Drawing.Size(236, 19);
            this.tb_itemName.TabIndex = 18;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.ButtonFont = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_save.ButtonText = "Save";
            this.btn_save.defaultBackColor = System.Drawing.Color.Green;
            this.btn_save.defaultForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(899, 555);
            this.btn_save.Name = "btn_save";
            this.btn_save.onClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_save.onClickForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_save.onOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_save.onOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_save.Size = new System.Drawing.Size(119, 48);
            this.btn_save.TabIndex = 17;
            this.btn_save.textSize = 0;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.ButtonFont = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_delete.ButtonText = "Delete";
            this.btn_delete.defaultBackColor = System.Drawing.Color.Maroon;
            this.btn_delete.defaultForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(785, 555);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.onClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_delete.onClickForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_delete.onOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_delete.onOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_delete.Size = new System.Drawing.Size(119, 48);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.textSize = 0;
            // 
            // roundPanel6
            // 
            this.roundPanel6._BackColor = System.Drawing.Color.White;
            this.roundPanel6._BorderColor = System.Drawing.Color.DarkGray;
            this.roundPanel6._CornerRadius = 5F;
            this.roundPanel6._Shadow = false;
            this.roundPanel6.BackColor = System.Drawing.Color.White;
            this.roundPanel6.Location = new System.Drawing.Point(753, 323);
            this.roundPanel6.Name = "roundPanel6";
            this.roundPanel6.Size = new System.Drawing.Size(265, 211);
            this.roundPanel6.TabIndex = 15;
            // 
            // roundPanel5
            // 
            this.roundPanel5._BackColor = System.Drawing.Color.White;
            this.roundPanel5._BorderColor = System.Drawing.Color.DarkGray;
            this.roundPanel5._CornerRadius = 5F;
            this.roundPanel5._Shadow = false;
            this.roundPanel5.BackColor = System.Drawing.Color.White;
            this.roundPanel5.Location = new System.Drawing.Point(757, 254);
            this.roundPanel5.Name = "roundPanel5";
            this.roundPanel5.Size = new System.Drawing.Size(265, 49);
            this.roundPanel5.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(749, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price";
            // 
            // roundPanel4
            // 
            this.roundPanel4._BackColor = System.Drawing.Color.White;
            this.roundPanel4._BorderColor = System.Drawing.Color.DarkGray;
            this.roundPanel4._CornerRadius = 5F;
            this.roundPanel4._Shadow = false;
            this.roundPanel4.BackColor = System.Drawing.Color.White;
            this.roundPanel4.Location = new System.Drawing.Point(753, 185);
            this.roundPanel4.Name = "roundPanel4";
            this.roundPanel4.Size = new System.Drawing.Size(265, 49);
            this.roundPanel4.TabIndex = 11;
            // 
            // roundPanel3
            // 
            this.roundPanel3._BackColor = System.Drawing.Color.White;
            this.roundPanel3._BorderColor = System.Drawing.Color.DarkGray;
            this.roundPanel3._CornerRadius = 5F;
            this.roundPanel3._Shadow = false;
            this.roundPanel3.BackColor = System.Drawing.Color.White;
            this.roundPanel3.Location = new System.Drawing.Point(753, 116);
            this.roundPanel3.Name = "roundPanel3";
            this.roundPanel3.Size = new System.Drawing.Size(265, 49);
            this.roundPanel3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(745, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Item Name";
            // 
            // btn_printMenu
            // 
            this.btn_printMenu.BackColor = System.Drawing.Color.White;
            this.btn_printMenu.ButtonFont = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_printMenu.ButtonText = "Print new menu 🖨";
            this.btn_printMenu.defaultBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_printMenu.defaultForeColor = System.Drawing.Color.White;
            this.btn_printMenu.Location = new System.Drawing.Point(498, 22);
            this.btn_printMenu.Name = "btn_printMenu";
            this.btn_printMenu.onClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_printMenu.onClickForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_printMenu.onOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_printMenu.onOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_printMenu.Size = new System.Drawing.Size(178, 48);
            this.btn_printMenu.TabIndex = 7;
            this.btn_printMenu.textSize = 0;
            this.btn_printMenu.Click += new System.EventHandler(this.btn_printMenu_Click);
            // 
            // itemArea
            // 
            this.itemArea.AutoScroll = true;
            this.itemArea.BackColor = System.Drawing.Color.White;
            this.itemArea.Location = new System.Drawing.Point(15, 93);
            this.itemArea.Name = "itemArea";
            this.itemArea.Size = new System.Drawing.Size(681, 486);
            this.itemArea.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(745, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Properties";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select an Item To Manage";
            // 
            // devider2
            // 
            this.devider2.BackColor = System.Drawing.Color.White;
            this.devider2.Location = new System.Drawing.Point(725, 70);
            this.devider2.Name = "devider2";
            this.devider2.Size = new System.Drawing.Size(312, 16);
            this.devider2.TabIndex = 3;
            // 
            // devider1
            // 
            this.devider1.BackColor = System.Drawing.Color.White;
            this.devider1.Location = new System.Drawing.Point(15, 69);
            this.devider1.Name = "devider1";
            this.devider1.Size = new System.Drawing.Size(681, 18);
            this.devider1.TabIndex = 2;
            // 
            // roundPanel2
            // 
            this.roundPanel2._BackColor = System.Drawing.Color.White;
            this.roundPanel2._BorderColor = System.Drawing.Color.Empty;
            this.roundPanel2._CornerRadius = 20F;
            this.roundPanel2._Shadow = true;
            this.roundPanel2.BackColor = System.Drawing.Color.Transparent;
            this.roundPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundPanel2.Location = new System.Drawing.Point(710, 0);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Size = new System.Drawing.Size(337, 618);
            this.roundPanel2.TabIndex = 1;
            // 
            // roundPanel1
            // 
            this.roundPanel1._BackColor = System.Drawing.Color.White;
            this.roundPanel1._BorderColor = System.Drawing.Color.Empty;
            this.roundPanel1._CornerRadius = 20F;
            this.roundPanel1._Shadow = true;
            this.roundPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.roundPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(710, 618);
            this.roundPanel1.TabIndex = 0;
            // 
            // ManageItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 618);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "ManageItems";
            this.Text = "ManageItems";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_itemImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.FlowLayoutPanel itemArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Devider devider2;
        private Devider devider1;
        private RoundPanel roundPanel2;
        private RoundPanel roundPanel1;
        private PointOfSalesSystem.CustomButton btn_printMenu;
        private System.Drawing.Printing.PrintDocument printMenuDoc;
        private System.Windows.Forms.PrintPreviewDialog printPreviewMenuDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox img_itemImage;
        private System.Windows.Forms.ComboBox cb_itemCat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_itemPrice;
        private System.Windows.Forms.TextBox tb_itemName;
        private PointOfSalesSystem.CustomButton btn_save;
        private PointOfSalesSystem.CustomButton btn_delete;
        private RoundPanel roundPanel6;
        private RoundPanel roundPanel5;
        private System.Windows.Forms.Label label5;
        private RoundPanel roundPanel4;
        private RoundPanel roundPanel3;
        private System.Windows.Forms.Label lbl_id;
    }
}