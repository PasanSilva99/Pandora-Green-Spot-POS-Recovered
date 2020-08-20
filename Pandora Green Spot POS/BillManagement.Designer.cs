namespace Pandora_Green_Spot_POS
{
    partial class BillManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gradientPanel1 = new Pandora_Green_Spot_POS.GradientPanel();
            this.btn_today = new PointOfSalesSystem.CustomButton();
            this.btn_reload = new PointOfSalesSystem.CustomButton();
            this.btn_drop = new PointOfSalesSystem.CustomButton();
            this.billData = new System.Windows.Forms.DataGridView();
            this.devider1 = new Pandora_Green_Spot_POS.Devider();
            this.label1 = new System.Windows.Forms.Label();
            this.roundPanel1 = new Pandora_Green_Spot_POS.RoundPanel();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billData)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(217)))));
            this.gradientPanel1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.gradientPanel1.Controls.Add(this.btn_today);
            this.gradientPanel1.Controls.Add(this.btn_reload);
            this.gradientPanel1.Controls.Add(this.btn_drop);
            this.gradientPanel1.Controls.Add(this.billData);
            this.gradientPanel1.Controls.Add(this.devider1);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.roundPanel1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(884, 520);
            this.gradientPanel1.TabIndex = 0;
            // 
            // btn_today
            // 
            this.btn_today.BackColor = System.Drawing.Color.White;
            this.btn_today.ButtonFont = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_today.ButtonText = "Today\'s Bill";
            this.btn_today.defaultBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_today.defaultForeColor = System.Drawing.Color.White;
            this.btn_today.Location = new System.Drawing.Point(73, 454);
            this.btn_today.Name = "btn_today";
            this.btn_today.onClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_today.onClickForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_today.onOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_today.onOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_today.Size = new System.Drawing.Size(217, 45);
            this.btn_today.TabIndex = 6;
            this.btn_today.textSize = 0;
            this.btn_today.Click += new System.EventHandler(this.btn_today_Click);
            // 
            // btn_reload
            // 
            this.btn_reload.BackColor = System.Drawing.Color.White;
            this.btn_reload.ButtonFont = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_reload.ButtonText = "Reload all Bills";
            this.btn_reload.defaultBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_reload.defaultForeColor = System.Drawing.Color.White;
            this.btn_reload.Location = new System.Drawing.Point(422, 454);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.onClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_reload.onClickForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_reload.onOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_reload.onOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_reload.Size = new System.Drawing.Size(217, 45);
            this.btn_reload.TabIndex = 5;
            this.btn_reload.textSize = 0;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btn_drop
            // 
            this.btn_drop.BackColor = System.Drawing.Color.White;
            this.btn_drop.ButtonFont = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_drop.ButtonText = "Reset all Bills";
            this.btn_drop.defaultBackColor = System.Drawing.Color.Firebrick;
            this.btn_drop.defaultForeColor = System.Drawing.Color.White;
            this.btn_drop.Location = new System.Drawing.Point(636, 454);
            this.btn_drop.Name = "btn_drop";
            this.btn_drop.onClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_drop.onClickForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_drop.onOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_drop.onOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_drop.Size = new System.Drawing.Size(217, 45);
            this.btn_drop.TabIndex = 4;
            this.btn_drop.textSize = 0;
            this.btn_drop.Click += new System.EventHandler(this.btn_drop_Click);
            // 
            // billData
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.billData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.billData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billData.BackgroundColor = System.Drawing.Color.White;
            this.billData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.billData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.billData.DefaultCellStyle = dataGridViewCellStyle3;
            this.billData.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.billData.Location = new System.Drawing.Point(19, 69);
            this.billData.Name = "billData";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.billData.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.billData.Size = new System.Drawing.Size(845, 379);
            this.billData.TabIndex = 3;
            // 
            // devider1
            // 
            this.devider1.BackColor = System.Drawing.Color.White;
            this.devider1.Location = new System.Drawing.Point(17, 46);
            this.devider1.Name = "devider1";
            this.devider1.Size = new System.Drawing.Size(849, 17);
            this.devider1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bill Management";
            // 
            // roundPanel1
            // 
            this.roundPanel1._BackColor = System.Drawing.Color.White;
            this.roundPanel1._BorderColor = System.Drawing.Color.Empty;
            this.roundPanel1._CornerRadius = 20F;
            this.roundPanel1._Shadow = true;
            this.roundPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundPanel1.Location = new System.Drawing.Point(6, 3);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(870, 508);
            this.roundPanel1.TabIndex = 0;
            // 
            // BillManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 520);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "BillManagement";
            this.Text = "Bill Management";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private RoundPanel roundPanel1;
        private System.Windows.Forms.DataGridView billData;
        private Devider devider1;
        private System.Windows.Forms.Label label1;
        private PointOfSalesSystem.CustomButton btn_reload;
        private PointOfSalesSystem.CustomButton btn_drop;
        private PointOfSalesSystem.CustomButton btn_today;
    }
}