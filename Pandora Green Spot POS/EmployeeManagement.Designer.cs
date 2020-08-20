namespace Pandora_Green_Spot_POS
{
    partial class EmployeeManagement
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
            this.back = new Pandora_Green_Spot_POS.GradientPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_Priviladge = new System.Windows.Forms.ComboBox();
            this.btn_save = new PointOfSalesSystem.CustomButton();
            this.btn_remove = new PointOfSalesSystem.CustomButton();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.roundPanel3 = new Pandora_Green_Spot_POS.RoundPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.roundPanel8 = new Pandora_Green_Spot_POS.RoundPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.roundPanel7 = new Pandora_Green_Spot_POS.RoundPanel();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.roundPanel6 = new Pandora_Green_Spot_POS.RoundPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.roundPanel4 = new Pandora_Green_Spot_POS.RoundPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.roundPanel5 = new Pandora_Green_Spot_POS.RoundPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.roundPanel2 = new Pandora_Green_Spot_POS.RoundPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.EmployeeArea = new System.Windows.Forms.FlowLayoutPanel();
            this.devider1 = new Pandora_Green_Spot_POS.Devider();
            this.btn_addEmp = new PointOfSalesSystem.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.devider2 = new Pandora_Green_Spot_POS.Devider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundPanel1 = new Pandora_Green_Spot_POS.RoundPanel();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.pnl_username = new Pandora_Green_Spot_POS.RoundPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.back.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(217)))));
            this.back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.back.Controls.Add(this.devider2);
            this.back.Controls.Add(this.btn_addEmp);
            this.back.Controls.Add(this.tb_userName);
            this.back.Controls.Add(this.pnl_username);
            this.back.Controls.Add(this.label9);
            this.back.Controls.Add(this.label7);
            this.back.Controls.Add(this.cb_Priviladge);
            this.back.Controls.Add(this.btn_save);
            this.back.Controls.Add(this.btn_remove);
            this.back.Controls.Add(this.tb_lastName);
            this.back.Controls.Add(this.roundPanel3);
            this.back.Controls.Add(this.label3);
            this.back.Controls.Add(this.tb_password);
            this.back.Controls.Add(this.roundPanel8);
            this.back.Controls.Add(this.label8);
            this.back.Controls.Add(this.roundPanel7);
            this.back.Controls.Add(this.tb_address);
            this.back.Controls.Add(this.roundPanel6);
            this.back.Controls.Add(this.label6);
            this.back.Controls.Add(this.tb_mail);
            this.back.Controls.Add(this.roundPanel4);
            this.back.Controls.Add(this.label4);
            this.back.Controls.Add(this.tb_phone);
            this.back.Controls.Add(this.roundPanel5);
            this.back.Controls.Add(this.label5);
            this.back.Controls.Add(this.tb_firstName);
            this.back.Controls.Add(this.roundPanel2);
            this.back.Controls.Add(this.label2);
            this.back.Controls.Add(this.EmployeeArea);
            this.back.Controls.Add(this.devider1);
            this.back.Controls.Add(this.label1);
            this.back.Controls.Add(this.panel1);
            this.back.Controls.Add(this.roundPanel1);
            this.back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(866, 670);
            this.back.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(483, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Privilege Level";
            // 
            // cb_Priviladge
            // 
            this.cb_Priviladge.AutoCompleteCustomSource.AddRange(new string[] {
            "Admin",
            "User"});
            this.cb_Priviladge.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Priviladge.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Priviladge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Priviladge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Priviladge.FormattingEnabled = true;
            this.cb_Priviladge.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cb_Priviladge.Location = new System.Drawing.Point(505, 481);
            this.cb_Priviladge.Name = "cb_Priviladge";
            this.cb_Priviladge.Size = new System.Drawing.Size(291, 21);
            this.cb_Priviladge.TabIndex = 33;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.ButtonFont = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_save.ButtonText = "Udate";
            this.btn_save.defaultBackColor = System.Drawing.Color.Green;
            this.btn_save.defaultForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(741, 600);
            this.btn_save.Name = "btn_save";
            this.btn_save.onClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_save.onClickForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_save.onOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_save.onOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_save.Size = new System.Drawing.Size(80, 44);
            this.btn_save.TabIndex = 32;
            this.btn_save.textSize = 0;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.White;
            this.btn_remove.ButtonFont = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_remove.ButtonText = "Remove User";
            this.btn_remove.defaultBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_remove.defaultForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(623, 600);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.onClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_remove.onClickForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_remove.onOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_remove.onOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_remove.Size = new System.Drawing.Size(121, 44);
            this.btn_remove.TabIndex = 31;
            this.btn_remove.textSize = 0;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // tb_lastName
            // 
            this.tb_lastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lastName.Location = new System.Drawing.Point(677, 162);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(120, 15);
            this.tb_lastName.TabIndex = 30;
            // 
            // roundPanel3
            // 
            this.roundPanel3._BackColor = System.Drawing.Color.White;
            this.roundPanel3._BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundPanel3._CornerRadius = 20F;
            this.roundPanel3._Shadow = true;
            this.roundPanel3.BackColor = System.Drawing.Color.White;
            this.roundPanel3.Location = new System.Drawing.Point(652, 144);
            this.roundPanel3.Name = "roundPanel3";
            this.roundPanel3.Size = new System.Drawing.Size(169, 48);
            this.roundPanel3.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(655, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "First Name";
            // 
            // tb_password
            // 
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(505, 550);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '•';
            this.tb_password.Size = new System.Drawing.Size(292, 15);
            this.tb_password.TabIndex = 27;
            // 
            // roundPanel8
            // 
            this.roundPanel8._BackColor = System.Drawing.Color.White;
            this.roundPanel8._BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundPanel8._CornerRadius = 20F;
            this.roundPanel8._Shadow = true;
            this.roundPanel8.BackColor = System.Drawing.Color.White;
            this.roundPanel8.Location = new System.Drawing.Point(480, 532);
            this.roundPanel8.Name = "roundPanel8";
            this.roundPanel8.Size = new System.Drawing.Size(341, 48);
            this.roundPanel8.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(483, 518);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Password";
            // 
            // roundPanel7
            // 
            this.roundPanel7._BackColor = System.Drawing.Color.White;
            this.roundPanel7._BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundPanel7._CornerRadius = 20F;
            this.roundPanel7._Shadow = true;
            this.roundPanel7.BackColor = System.Drawing.Color.White;
            this.roundPanel7.Location = new System.Drawing.Point(480, 467);
            this.roundPanel7.Name = "roundPanel7";
            this.roundPanel7.Size = new System.Drawing.Size(341, 48);
            this.roundPanel7.TabIndex = 23;
            // 
            // tb_address
            // 
            this.tb_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_address.Location = new System.Drawing.Point(505, 360);
            this.tb_address.Multiline = true;
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(292, 71);
            this.tb_address.TabIndex = 21;
            // 
            // roundPanel6
            // 
            this.roundPanel6._BackColor = System.Drawing.Color.White;
            this.roundPanel6._BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundPanel6._CornerRadius = 20F;
            this.roundPanel6._Shadow = true;
            this.roundPanel6.BackColor = System.Drawing.Color.White;
            this.roundPanel6.Location = new System.Drawing.Point(480, 338);
            this.roundPanel6.Name = "roundPanel6";
            this.roundPanel6.Size = new System.Drawing.Size(341, 112);
            this.roundPanel6.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(483, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Address";
            // 
            // tb_mail
            // 
            this.tb_mail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mail.Location = new System.Drawing.Point(505, 291);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(292, 15);
            this.tb_mail.TabIndex = 18;
            // 
            // roundPanel4
            // 
            this.roundPanel4._BackColor = System.Drawing.Color.White;
            this.roundPanel4._BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundPanel4._CornerRadius = 20F;
            this.roundPanel4._Shadow = true;
            this.roundPanel4.BackColor = System.Drawing.Color.White;
            this.roundPanel4.Location = new System.Drawing.Point(480, 273);
            this.roundPanel4.Name = "roundPanel4";
            this.roundPanel4.Size = new System.Drawing.Size(341, 48);
            this.roundPanel4.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(483, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "E-mail Address";
            // 
            // tb_phone
            // 
            this.tb_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phone.Location = new System.Drawing.Point(505, 227);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(292, 15);
            this.tb_phone.TabIndex = 15;
            // 
            // roundPanel5
            // 
            this.roundPanel5._BackColor = System.Drawing.Color.White;
            this.roundPanel5._BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundPanel5._CornerRadius = 20F;
            this.roundPanel5._Shadow = true;
            this.roundPanel5.BackColor = System.Drawing.Color.White;
            this.roundPanel5.Location = new System.Drawing.Point(480, 209);
            this.roundPanel5.Name = "roundPanel5";
            this.roundPanel5.Size = new System.Drawing.Size(341, 48);
            this.roundPanel5.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(483, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Phone Number";
            // 
            // tb_firstName
            // 
            this.tb_firstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_firstName.Location = new System.Drawing.Point(505, 162);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(120, 15);
            this.tb_firstName.TabIndex = 9;
            // 
            // roundPanel2
            // 
            this.roundPanel2._BackColor = System.Drawing.Color.White;
            this.roundPanel2._BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundPanel2._CornerRadius = 20F;
            this.roundPanel2._Shadow = true;
            this.roundPanel2.BackColor = System.Drawing.Color.White;
            this.roundPanel2.Location = new System.Drawing.Point(480, 144);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Size = new System.Drawing.Size(169, 48);
            this.roundPanel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name";
            // 
            // EmployeeArea
            // 
            this.EmployeeArea.BackColor = System.Drawing.Color.White;
            this.EmployeeArea.Location = new System.Drawing.Point(18, 67);
            this.EmployeeArea.Name = "EmployeeArea";
            this.EmployeeArea.Size = new System.Drawing.Size(445, 520);
            this.EmployeeArea.TabIndex = 6;
            // 
            // devider1
            // 
            this.devider1.BackColor = System.Drawing.Color.White;
            this.devider1.Location = new System.Drawing.Point(13, 50);
            this.devider1.Name = "devider1";
            this.devider1.Size = new System.Drawing.Size(454, 13);
            this.devider1.TabIndex = 2;
            // 
            // btn_addEmp
            // 
            this.btn_addEmp.BackColor = System.Drawing.Color.White;
            this.btn_addEmp.ButtonFont = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_addEmp.ButtonText = "➕ Add New ";
            this.btn_addEmp.defaultBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_addEmp.defaultForeColor = System.Drawing.Color.White;
            this.btn_addEmp.Location = new System.Drawing.Point(486, 14);
            this.btn_addEmp.Name = "btn_addEmp";
            this.btn_addEmp.onClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_addEmp.onClickForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_addEmp.onOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_addEmp.onOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_addEmp.Size = new System.Drawing.Size(335, 44);
            this.btn_addEmp.TabIndex = 5;
            this.btn_addEmp.textSize = 0;
            this.btn_addEmp.Click += new System.EventHandler(this.btn_addEmp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select an Employee to Manage";
            // 
            // devider2
            // 
            this.devider2.BackColor = System.Drawing.Color.White;
            this.devider2.Location = new System.Drawing.Point(471, 49);
            this.devider2.Name = "devider2";
            this.devider2.Size = new System.Drawing.Size(380, 15);
            this.devider2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(469, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 579);
            this.panel1.TabIndex = 1;
            // 
            // roundPanel1
            // 
            this.roundPanel1._BackColor = System.Drawing.Color.White;
            this.roundPanel1._BorderColor = System.Drawing.Color.Empty;
            this.roundPanel1._CornerRadius = 20F;
            this.roundPanel1._Shadow = true;
            this.roundPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundPanel1.Location = new System.Drawing.Point(2, 2);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(859, 665);
            this.roundPanel1.TabIndex = 0;
            // 
            // tb_userName
            // 
            this.tb_userName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tb_userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_userName.Location = new System.Drawing.Point(505, 99);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(292, 15);
            this.tb_userName.TabIndex = 36;
            // 
            // pnl_username
            // 
            this.pnl_username._BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnl_username._BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnl_username._CornerRadius = 20F;
            this.pnl_username._Shadow = true;
            this.pnl_username.BackColor = System.Drawing.Color.White;
            this.pnl_username.Location = new System.Drawing.Point(480, 81);
            this.pnl_username.Name = "pnl_username";
            this.pnl_username.Size = new System.Drawing.Size(341, 48);
            this.pnl_username.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(483, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "User Name ";
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 670);
            this.Controls.Add(this.back);
            this.Name = "EmployeeManagement";
            this.Text = "EmployeeManagement";
            this.Load += new System.EventHandler(this.EmployeeManagement_Load);
            this.back.ResumeLayout(false);
            this.back.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel back;
        private RoundPanel roundPanel1;
        private PointOfSalesSystem.CustomButton btn_save;
        private PointOfSalesSystem.CustomButton btn_remove;
        private System.Windows.Forms.TextBox tb_lastName;
        private RoundPanel roundPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_password;
        private RoundPanel roundPanel8;
        private System.Windows.Forms.Label label8;
        private RoundPanel roundPanel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_address;
        private RoundPanel roundPanel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_mail;
        private RoundPanel roundPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_phone;
        private RoundPanel roundPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_firstName;
        private RoundPanel roundPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel EmployeeArea;
        private Devider devider1;
        private PointOfSalesSystem.CustomButton btn_addEmp;
        private System.Windows.Forms.Label label1;
        private Devider devider2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_Priviladge;
        private System.Windows.Forms.TextBox tb_userName;
        private RoundPanel pnl_username;
        private System.Windows.Forms.Label label9;
    }
}