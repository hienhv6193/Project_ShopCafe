namespace ShopCafeClient
{
    partial class adminCategory
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListCategory = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCategoryID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbCategoryName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCategory)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục";
            // 
            // dgvListCategory
            // 
            this.dgvListCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCategory.Location = new System.Drawing.Point(3, 3);
            this.dgvListCategory.Name = "dgvListCategory";
            this.dgvListCategory.RowHeadersWidth = 51;
            this.dgvListCategory.RowTemplate.Height = 24;
            this.dgvListCategory.Size = new System.Drawing.Size(383, 338);
            this.dgvListCategory.TabIndex = 1;
            this.dgvListCategory.SelectionChanged += new System.EventHandler(this.dgvListCategory_SelectionChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(13, 22);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(99, 40);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Update.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.Location = new System.Drawing.Point(139, 22);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(89, 40);
            this.Btn_Update.TabIndex = 3;
            this.Btn_Update.Text = "Sửa";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Delete.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(259, 22);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(87, 40);
            this.Btn_Delete.TabIndex = 4;
            this.Btn_Delete.Text = "Xóa";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID:";
            // 
            // txbCategoryID
            // 
            this.txbCategoryID.BackColor = System.Drawing.SystemColors.Window;
            this.txbCategoryID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCategoryID.Enabled = false;
            this.txbCategoryID.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCategoryID.ForeColor = System.Drawing.SystemColors.Window;
            this.txbCategoryID.Location = new System.Drawing.Point(119, 13);
            this.txbCategoryID.Name = "txbCategoryID";
            this.txbCategoryID.Size = new System.Drawing.Size(227, 40);
            this.txbCategoryID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvListCategory);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 349);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbCategoryName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txbCategoryID);
            this.panel2.Location = new System.Drawing.Point(420, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 142);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Add);
            this.panel3.Controls.Add(this.Btn_Update);
            this.panel3.Controls.Add(this.Btn_Delete);
            this.panel3.Location = new System.Drawing.Point(420, 309);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 79);
            this.panel3.TabIndex = 12;
            // 
            // txbCategoryName
            // 
            this.txbCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCategoryName.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCategoryName.Location = new System.Drawing.Point(119, 73);
            this.txbCategoryName.Name = "txbCategoryName";
            this.txbCategoryName.Size = new System.Drawing.Size(227, 40);
            this.txbCategoryName.TabIndex = 9;
            // 
            // adminCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 430);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "adminCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminCategory";
            this.Load += new System.EventHandler(this.adminCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCategory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListCategory;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCategoryID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbCategoryName;
    }
}