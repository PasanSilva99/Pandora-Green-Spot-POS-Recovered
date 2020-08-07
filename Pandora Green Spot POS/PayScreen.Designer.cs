namespace Pandora_Green_Spot_POS
{
    partial class PayScreen
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
            this.gradientPanel1 = new Pandora_Green_Spot_POS.GradientPanel();
            this.customButton1 = new PointOfSalesSystem.CustomButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.tb_cusCash = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_totalBill = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.devider1 = new Pandora_Green_Spot_POS.Devider();
            this.roundPanel1 = new Pandora_Green_Spot_POS.RoundPanel();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(217)))));
            this.gradientPanel1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.gradientPanel1.Controls.Add(this.customButton1);
            this.gradientPanel1.Controls.Add(this.label9);
            this.gradientPanel1.Controls.Add(this.label8);
            this.gradientPanel1.Controls.Add(this.label7);
            this.gradientPanel1.Controls.Add(this.lbl_balance);
            this.gradientPanel1.Controls.Add(this.tb_cusCash);
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.lbl_totalBill);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.devider1);
            this.gradientPanel1.Controls.Add(this.roundPanel1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(350, 336);
            this.gradientPanel1.TabIndex = 0;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.White;
            this.customButton1.ButtonFont = new System.Drawing.Font("Century Gothic", 10F);
            this.customButton1.ButtonText = "✔ Complete ";
            this.customButton1.defaultBackColor = System.Drawing.Color.Green;
            this.customButton1.defaultForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(19, 254);
            this.customButton1.Name = "customButton1";
            this.customButton1.onClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.customButton1.onClickForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customButton1.onOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.customButton1.onOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customButton1.Size = new System.Drawing.Size(309, 50);
            this.customButton1.TabIndex = 13;
            this.customButton1.textSize = 0;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(198, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Rs.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(198, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Rs.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(198, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Rs.";
            // 
            // lbl_balance
            // 
            this.lbl_balance.BackColor = System.Drawing.Color.White;
            this.lbl_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balance.Location = new System.Drawing.Point(238, 154);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_balance.Size = new System.Drawing.Size(84, 20);
            this.lbl_balance.TabIndex = 9;
            this.lbl_balance.Text = "0";
            this.lbl_balance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_cusCash
            // 
            this.tb_cusCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_cusCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cusCash.Location = new System.Drawing.Point(237, 114);
            this.tb_cusCash.Name = "tb_cusCash";
            this.tb_cusCash.Size = new System.Drawing.Size(84, 26);
            this.tb_cusCash.TabIndex = 8;
            this.tb_cusCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_cusCash.TextChanged += new System.EventHandler(this.tb_cusCash_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cash";
            // 
            // lbl_totalBill
            // 
            this.lbl_totalBill.BackColor = System.Drawing.Color.White;
            this.lbl_totalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalBill.Location = new System.Drawing.Point(237, 83);
            this.lbl_totalBill.Name = "lbl_totalBill";
            this.lbl_totalBill.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_totalBill.Size = new System.Drawing.Size(84, 20);
            this.lbl_totalBill.TabIndex = 4;
            this.lbl_totalBill.Text = "0";
            this.lbl_totalBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Bill";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pay Bill";
            // 
            // devider1
            // 
            this.devider1.BackColor = System.Drawing.Color.White;
            this.devider1.Location = new System.Drawing.Point(12, 42);
            this.devider1.Name = "devider1";
            this.devider1.Size = new System.Drawing.Size(326, 20);
            this.devider1.TabIndex = 1;
            // 
            // roundPanel1
            // 
            this.roundPanel1._BackColor = System.Drawing.Color.White;
            this.roundPanel1._BorderColor = System.Drawing.Color.Empty;
            this.roundPanel1._CornerRadius = 20F;
            this.roundPanel1._Shadow = true;
            this.roundPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(350, 336);
            this.roundPanel1.TabIndex = 0;
            // 
            // PayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 336);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PayScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PayScreen";
            this.Load += new System.EventHandler(this.PayScreen_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private RoundPanel roundPanel1;
        private System.Windows.Forms.Label label1;
        private Devider devider1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.TextBox tb_cusCash;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_totalBill;
        private System.Windows.Forms.Label label2;
        private PointOfSalesSystem.CustomButton customButton1;
    }
}