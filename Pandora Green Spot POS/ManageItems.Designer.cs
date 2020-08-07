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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageItems));
            this.printMenuDoc = new System.Drawing.Printing.PrintDocument();
            this.printPreviewMenuDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.gradientPanel1 = new Pandora_Green_Spot_POS.GradientPanel();
            this.btn_printMenu = new PointOfSalesSystem.CustomButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.devider2 = new Pandora_Green_Spot_POS.Devider();
            this.devider1 = new Pandora_Green_Spot_POS.Devider();
            this.roundPanel2 = new Pandora_Green_Spot_POS.RoundPanel();
            this.roundPanel1 = new Pandora_Green_Spot_POS.RoundPanel();
            this.gradientPanel1.SuspendLayout();
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
            // gradientPanel1
            // 
            this.gradientPanel1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(217)))));
            this.gradientPanel1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.gradientPanel1.Controls.Add(this.btn_printMenu);
            this.gradientPanel1.Controls.Add(this.flowLayoutPanel1);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 93);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(681, 486);
            this.flowLayoutPanel1.TabIndex = 6;
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
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Devider devider2;
        private Devider devider1;
        private RoundPanel roundPanel2;
        private RoundPanel roundPanel1;
        private PointOfSalesSystem.CustomButton btn_printMenu;
        private System.Drawing.Printing.PrintDocument printMenuDoc;
        private System.Windows.Forms.PrintPreviewDialog printPreviewMenuDialog;
    }
}