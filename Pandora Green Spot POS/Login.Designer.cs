using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Pandora_Green_Spot_POS
{
    partial class Login
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
            this.customButton3 = new PointOfSalesSystem.CustomButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradientPanel3 = new Pandora_Green_Spot_POS.GradientPanel();
            this.gradientPanel2 = new Pandora_Green_Spot_POS.GradientPanel();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.customButton2 = new PointOfSalesSystem.CustomButton();
            this.btn_login = new PointOfSalesSystem.CustomButton();
            this.roundPanel2 = new Pandora_Green_Spot_POS.RoundPanel();
            this.roundPanel1 = new Pandora_Green_Spot_POS.RoundPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.UserImage = new System.Windows.Forms.PictureBox();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(198)))));
            this.gradientPanel1.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(208)))), ((int)(((byte)(80)))));
            this.gradientPanel1.Controls.Add(this.customButton3);
            this.gradientPanel1.Controls.Add(this.label6);
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.linkLabel1);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.gradientPanel3);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(425, 485);
            this.gradientPanel1.TabIndex = 0;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.Transparent;
            this.customButton3.ButtonFont = new System.Drawing.Font("Century Gothic", 10F);
            this.customButton3.ButtonText = "Guest Login";
            this.customButton3.defaultBackColor = System.Drawing.Color.Teal;
            this.customButton3.defaultForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(40, 407);
            this.customButton3.Name = "customButton3";
            this.customButton3.onClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.customButton3.onClickForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customButton3.onOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.customButton3.onOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customButton3.Size = new System.Drawing.Size(334, 51);
            this.customButton3.TabIndex = 6;
            this.customButton3.textSize = 0;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(36, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(353, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "login with the guest mode";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(36, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "or";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.Location = new System.Drawing.Point(36, 319);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(353, 23);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Contact Admin ";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(36, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Not a Registered User? ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 47);
            this.label3.TabIndex = 3;
            this.label3.Text = "Please Login with your registered credentials to Continue";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome to Pandora Green Spot";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Pandora_Green_Spot_POS.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(127, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.Color1 = System.Drawing.Color.DodgerBlue;
            this.gradientPanel3.Color2 = System.Drawing.Color.MediumTurquoise;
            this.gradientPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.gradientPanel3.Location = new System.Drawing.Point(423, 0);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(2, 485);
            this.gradientPanel3.TabIndex = 0;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(111)))), ((int)(((byte)(198)))));
            this.gradientPanel2.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(208)))), ((int)(((byte)(80)))));
            this.gradientPanel2.Controls.Add(this.TB_Password);
            this.gradientPanel2.Controls.Add(this.TB_UserName);
            this.gradientPanel2.Controls.Add(this.pictureBox3);
            this.gradientPanel2.Controls.Add(this.pictureBox2);
            this.gradientPanel2.Controls.Add(this.customButton2);
            this.gradientPanel2.Controls.Add(this.btn_login);
            this.gradientPanel2.Controls.Add(this.roundPanel2);
            this.gradientPanel2.Controls.Add(this.roundPanel1);
            this.gradientPanel2.Controls.Add(this.label1);
            this.gradientPanel2.Controls.Add(this.UserImage);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gradientPanel2.Location = new System.Drawing.Point(425, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(375, 485);
            this.gradientPanel2.TabIndex = 1;
            // 
            // TB_Password
            // 
            this.TB_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Password.Location = new System.Drawing.Point(80, 298);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '•';
            this.TB_Password.Size = new System.Drawing.Size(250, 19);
            this.TB_Password.TabIndex = 9;
            // 
            // TB_UserName
            // 
            this.TB_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_UserName.Location = new System.Drawing.Point(80, 239);
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(250, 19);
            this.TB_UserName.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::Pandora_Green_Spot_POS.Properties.Resources.password;
            this.pictureBox3.Location = new System.Drawing.Point(50, 294);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::Pandora_Green_Spot_POS.Properties.Resources.usern;
            this.pictureBox2.Location = new System.Drawing.Point(50, 235);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.Transparent;
            this.customButton2.ButtonFont = new System.Drawing.Font("Century Gothic", 10F);
            this.customButton2.ButtonText = "Cancel";
            this.customButton2.defaultBackColor = System.Drawing.Color.Crimson;
            this.customButton2.defaultForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(29, 406);
            this.customButton2.Name = "customButton2";
            this.customButton2.onClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.customButton2.onClickForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customButton2.onOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.customButton2.onOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customButton2.Size = new System.Drawing.Size(334, 51);
            this.customButton2.TabIndex = 5;
            this.customButton2.textSize = 0;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.ButtonFont = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_login.ButtonText = "Login";
            this.btn_login.defaultBackColor = System.Drawing.Color.Green;
            this.btn_login.defaultForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(30, 359);
            this.btn_login.Name = "btn_login";
            this.btn_login.onClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_login.onClickForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_login.onOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_login.onOverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_login.Size = new System.Drawing.Size(334, 51);
            this.btn_login.TabIndex = 4;
            this.btn_login.textSize = 0;
            this.btn_login.Load += new System.EventHandler(this.customButton1_Load);
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // roundPanel2
            // 
            this.roundPanel2._BackColor = System.Drawing.Color.White;
            this.roundPanel2._Shadow = true;
            this.roundPanel2.BackColor = System.Drawing.Color.Transparent;
            this.roundPanel2.Location = new System.Drawing.Point(26, 276);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Size = new System.Drawing.Size(337, 57);
            this.roundPanel2.TabIndex = 3;
            // 
            // roundPanel1
            // 
            this.roundPanel1._BackColor = System.Drawing.Color.White;
            this.roundPanel1._Shadow = true;
            this.roundPanel1.BackColor = System.Drawing.Color.Transparent;
            this.roundPanel1.Location = new System.Drawing.Point(26, 219);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(337, 57);
            this.roundPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome";
            // 
            // UserImage
            // 
            this.UserImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserImage.BackColor = System.Drawing.Color.Transparent;
            this.UserImage.Image = global::Pandora_Green_Spot_POS.Properties.Resources._lock;
            this.UserImage.Location = new System.Drawing.Point(136, 18);
            this.UserImage.Name = "UserImage";
            this.UserImage.Size = new System.Drawing.Size(120, 120);
            this.UserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserImage.TabIndex = 0;
            this.UserImage.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.gradientPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private GradientPanel gradientPanel3;
        private GradientPanel gradientPanel2;
        private PictureBox UserImage;
        private Label label1;
        private Label label6;
        private Label label5;
        private LinkLabel linkLabel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private RoundPanel roundPanel1;
        private RoundPanel roundPanel2;
        private PointOfSalesSystem.CustomButton btn_login;
        private PointOfSalesSystem.CustomButton customButton3;
        private TextBox TB_Password;
        private TextBox TB_UserName;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PointOfSalesSystem.CustomButton customButton2;
    }
}

