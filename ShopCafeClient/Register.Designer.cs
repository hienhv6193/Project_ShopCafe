using System.Windows.Forms;

namespace ShopCafeClient
{
    partial class Register
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbHidePass = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbPlace = new System.Windows.Forms.TextBox();
            this.lbYear = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbCheckPass = new System.Windows.Forms.TextBox();
            this.lbRePass = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txbFullName = new System.Windows.Forms.TextBox();
            this.lbFullName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(341, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 669);
            this.panel1.TabIndex = 1;
            // 
            // ckbHidePass
            // 
            this.ckbHidePass.AutoSize = true;
            this.ckbHidePass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbHidePass.Location = new System.Drawing.Point(305, 18);
            this.ckbHidePass.Name = "ckbHidePass";
            this.ckbHidePass.Size = new System.Drawing.Size(214, 29);
            this.ckbHidePass.TabIndex = 9;
            this.ckbHidePass.Text = "Hiển thị mật khẩu";
            this.ckbHidePass.UseVisualStyleBackColor = true;
            this.ckbHidePass.CheckedChanged += new System.EventHandler(this.ckbHidePass_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbAddress);
            this.panel7.Controls.Add(this.lbAddress);
            this.panel7.Location = new System.Drawing.Point(33, 376);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(531, 49);
            this.panel7.TabIndex = 8;
            // 
            // txbAddress
            // 
            this.txbAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddress.Location = new System.Drawing.Point(231, 7);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(288, 30);
            this.txbAddress.TabIndex = 3;
            this.txbAddress.UseSystemPasswordChar = true;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(9, 12);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(90, 25);
            this.lbAddress.TabIndex = 2;
            this.lbAddress.Text = "Địa chỉ:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txbPhone);
            this.panel6.Controls.Add(this.lbPhone);
            this.panel6.Location = new System.Drawing.Point(33, 305);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(531, 49);
            this.panel6.TabIndex = 7;
            // 
            // txbPhone
            // 
            this.txbPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPhone.Location = new System.Drawing.Point(231, 7);
            this.txbPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(288, 30);
            this.txbPhone.TabIndex = 3;
            this.txbPhone.UseSystemPasswordChar = true;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(9, 12);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(149, 25);
            this.lbPhone.TabIndex = 2;
            this.lbPhone.Text = "Số điện thoại:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbPlace);
            this.panel5.Controls.Add(this.lbYear);
            this.panel5.Location = new System.Drawing.Point(33, 233);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(531, 49);
            this.panel5.TabIndex = 6;
            // 
            // txbPlace
            // 
            this.txbPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPlace.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPlace.Location = new System.Drawing.Point(231, 7);
            this.txbPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPlace.Name = "txbPlace";
            this.txbPlace.Size = new System.Drawing.Size(288, 30);
            this.txbPlace.TabIndex = 3;
            this.txbPlace.UseSystemPasswordChar = true;
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYear.Location = new System.Drawing.Point(9, 12);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(101, 25);
            this.lbYear.TabIndex = 2;
            this.lbYear.Text = "Nơi sinh:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbCheckPass);
            this.panel4.Controls.Add(this.lbRePass);
            this.panel4.Location = new System.Drawing.Point(33, 515);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(531, 49);
            this.panel4.TabIndex = 5;
            // 
            // txbCheckPass
            // 
            this.txbCheckPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCheckPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCheckPass.Location = new System.Drawing.Point(231, 7);
            this.txbCheckPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbCheckPass.Name = "txbCheckPass";
            this.txbCheckPass.Size = new System.Drawing.Size(288, 30);
            this.txbCheckPass.TabIndex = 3;
            this.txbCheckPass.UseSystemPasswordChar = true;
            // 
            // lbRePass
            // 
            this.lbRePass.AutoSize = true;
            this.lbRePass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRePass.Location = new System.Drawing.Point(9, 12);
            this.lbRePass.Name = "lbRePass";
            this.lbRePass.Size = new System.Drawing.Size(204, 25);
            this.lbRePass.TabIndex = 2;
            this.lbRePass.Text = "Nhập lại mật khẩu:";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(14, 14);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(125, 35);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(257, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đăng Ký";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbPass);
            this.panel3.Controls.Add(this.lbPass);
            this.panel3.Location = new System.Drawing.Point(33, 442);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(531, 51);
            this.panel3.TabIndex = 1;
            // 
            // txbPass
            // 
            this.txbPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPass.Location = new System.Drawing.Point(231, 10);
            this.txbPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(288, 30);
            this.txbPass.TabIndex = 1;
            this.txbPass.UseSystemPasswordChar = true;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(9, 15);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(119, 25);
            this.lbPass.TabIndex = 0;
            this.lbPass.Text = "Mật khẩu:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbUser);
            this.panel2.Controls.Add(this.lbUser);
            this.panel2.Location = new System.Drawing.Point(33, 159);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 51);
            this.panel2.TabIndex = 0;
            // 
            // txbUser
            // 
            this.txbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUser.Location = new System.Drawing.Point(231, 11);
            this.txbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(288, 30);
            this.txbUser.TabIndex = 1;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(9, 10);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(171, 25);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "Tên đăng nhập:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShopCafeClient.Properties.Resources.cafe;
            this.pictureBox1.Location = new System.Drawing.Point(30, 162);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnRegister);
            this.panel8.Controls.Add(this.ckbHidePass);
            this.panel8.Location = new System.Drawing.Point(33, 586);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(531, 67);
            this.panel8.TabIndex = 10;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txbFullName);
            this.panel9.Controls.Add(this.lbFullName);
            this.panel9.Location = new System.Drawing.Point(33, 83);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(531, 51);
            this.panel9.TabIndex = 2;
            // 
            // txbFullName
            // 
            this.txbFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFullName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFullName.Location = new System.Drawing.Point(231, 11);
            this.txbFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbFullName.Name = "txbFullName";
            this.txbFullName.Size = new System.Drawing.Size(288, 30);
            this.txbFullName.TabIndex = 1;
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullName.Location = new System.Drawing.Point(9, 10);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(116, 25);
            this.lbFullName.TabIndex = 0;
            this.lbFullName.Text = "Họ và tên:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 691);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private Panel panel1;
        private Button btnRegister;
        private Label label3;
        private Panel panel3;
        private TextBox txbPass;
        private Label lbPass;
        private Panel panel2;
        private TextBox txbUser;
        private Label lbUser;
        private Panel panel4;
        private TextBox txbCheckPass;
        private Label lbRePass;
        private PictureBox pictureBox1;
        private Panel panel5;
        private TextBox txbPlace;
        private Label lbYear;
        private Panel panel7;
        private TextBox txbAddress;
        private Label lbAddress;
        private Panel panel6;
        private TextBox txbPhone;
        private Label lbPhone;
        private CheckBox ckbHidePass;
        private Panel panel9;
        private TextBox txbFullName;
        private Label lbFullName;
        private Panel panel8;
    }
}