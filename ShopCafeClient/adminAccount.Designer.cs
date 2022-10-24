namespace ShopCafeClient
{
    partial class adminAccount
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
            this.dvcListAccount = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbDisplay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvcListAccount)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dvcListAccount);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 466);
            this.panel1.TabIndex = 0;
            // 
            // dvcListAccount
            // 
            this.dvcListAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvcListAccount.Location = new System.Drawing.Point(3, 3);
            this.dvcListAccount.Name = "dvcListAccount";
            this.dvcListAccount.RowHeadersWidth = 51;
            this.dvcListAccount.RowTemplate.Height = 24;
            this.dvcListAccount.Size = new System.Drawing.Size(561, 452);
            this.dvcListAccount.TabIndex = 0;
            this.dvcListAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvcListAccount_CellClick);
            this.dvcListAccount.SelectionChanged += new System.EventHandler(this.dvcListAccount_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(600, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 466);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbUser);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(16, 181);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(454, 58);
            this.panel7.TabIndex = 2;
            // 
            // txbUser
            // 
            this.txbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUser.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUser.Location = new System.Drawing.Point(186, 10);
            this.txbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(247, 40);
            this.txbUser.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên tài khoản:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbbType);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(17, 324);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(454, 58);
            this.panel6.TabIndex = 3;
            // 
            // cbbType
            // 
            this.cbbType.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "Quản lý ",
            "Nhân viên"});
            this.cbbType.Location = new System.Drawing.Point(185, 9);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(247, 41);
            this.cbbType.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại chức vụ:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbDisplay);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(16, 253);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(455, 58);
            this.panel5.TabIndex = 2;
            // 
            // txbDisplay
            // 
            this.txbDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDisplay.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDisplay.Location = new System.Drawing.Point(186, 10);
            this.txbDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDisplay.Name = "txbDisplay";
            this.txbDisplay.Size = new System.Drawing.Size(248, 40);
            this.txbDisplay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chức vụ:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbID);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(16, 105);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(454, 58);
            this.panel4.TabIndex = 1;
            // 
            // txbID
            // 
            this.txbID.BackColor = System.Drawing.SystemColors.Window;
            this.txbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbID.Enabled = false;
            this.txbID.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(186, 10);
            this.txbID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(247, 40);
            this.txbID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txbSearch);
            this.panel3.Location = new System.Drawing.Point(63, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(386, 67);
            this.panel3.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(234, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 40);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(14, 17);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(192, 40);
            this.txbSearch.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnAdd);
            this.panel8.Controls.Add(this.btnUpdate);
            this.panel8.Location = new System.Drawing.Point(18, 388);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(453, 67);
            this.panel8.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(57, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(238, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 36);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // adminAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 489);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "adminAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminAccount";
            this.Load += new System.EventHandler(this.adminAccount_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvcListAccount)).EndInit();
            this.panel2.ResumeLayout(false);
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
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.DataGridView dvcListAccount;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
    }
}