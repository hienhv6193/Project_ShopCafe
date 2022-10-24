namespace ShopCafeClient
{
    partial class adminFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminFood));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tvCategoryFood = new System.Windows.Forms.TreeView();
            this.imgLCategory = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvFood = new System.Windows.Forms.ListView();
            this.imgLarge = new System.Windows.Forms.ImageList(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbNameFood = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbbFood = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tvCategoryFood);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 672);
            this.panel1.TabIndex = 0;
            // 
            // tvCategoryFood
            // 
            this.tvCategoryFood.ImageIndex = 0;
            this.tvCategoryFood.ImageList = this.imgLCategory;
            this.tvCategoryFood.Location = new System.Drawing.Point(15, 15);
            this.tvCategoryFood.Name = "tvCategoryFood";
            this.tvCategoryFood.SelectedImageIndex = 0;
            this.tvCategoryFood.Size = new System.Drawing.Size(235, 654);
            this.tvCategoryFood.TabIndex = 0;
            this.tvCategoryFood.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCategoryFood_AfterSelect);
            // 
            // imgLCategory
            // 
            this.imgLCategory.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLCategory.ImageStream")));
            this.imgLCategory.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLCategory.Images.SetKeyName(0, "cafe.jpg");
            this.imgLCategory.Images.SetKeyName(1, "snack-khoatay-bobittet.jpg");
            this.imgLCategory.Images.SetKeyName(2, "mirinda-xaxi.jpg");
            this.imgLCategory.Images.SetKeyName(3, "aquafina.jpg");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvFood);
            this.panel2.Location = new System.Drawing.Point(271, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1191, 420);
            this.panel2.TabIndex = 1;
            // 
            // lvFood
            // 
            this.lvFood.HideSelection = false;
            this.lvFood.LargeImageList = this.imgLarge;
            this.lvFood.Location = new System.Drawing.Point(17, 3);
            this.lvFood.Name = "lvFood";
            this.lvFood.Size = new System.Drawing.Size(1153, 414);
            this.lvFood.SmallImageList = this.imgLarge;
            this.lvFood.TabIndex = 0;
            this.lvFood.UseCompatibleStateImageBehavior = false;
            this.lvFood.SelectedIndexChanged += new System.EventHandler(this.lvFood_SelectedIndexChanged);
            // 
            // imgLarge
            // 
            this.imgLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLarge.ImageStream")));
            this.imgLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLarge.Images.SetKeyName(0, "mirinda-cam.jpg");
            this.imgLarge.Images.SetKeyName(1, "mirinda-xaxi.jpg");
            this.imgLarge.Images.SetKeyName(2, "mirinda-kem.jpg");
            this.imgLarge.Images.SetKeyName(3, "fanta-nho.jpg");
            this.imgLarge.Images.SetKeyName(4, "khongdo.jpg");
            this.imgLarge.Images.SetKeyName(5, "pepsi-kocalo.jpg");
            this.imgLarge.Images.SetKeyName(6, "thtruewater.jpg");
            this.imgLarge.Images.SetKeyName(7, "dasani.jpg");
            this.imgLarge.Images.SetKeyName(8, "aquafina.jpg");
            this.imgLarge.Images.SetKeyName(9, "redbull.png");
            this.imgLarge.Images.SetKeyName(10, "revive.jpg");
            this.imgLarge.Images.SetKeyName(11, "mirinda-dame.jpg");
            this.imgLarge.Images.SetKeyName(12, "mirinda-fanta-xaxi.jpg");
            this.imgLarge.Images.SetKeyName(13, "pepsi.jpg");
            this.imgLarge.Images.SetKeyName(14, "spire.jpg");
            this.imgLarge.Images.SetKeyName(15, "coca.png");
            this.imgLarge.Images.SetKeyName(16, "snack-khoatay-bobittet.jpg");
            this.imgLarge.Images.SetKeyName(17, "snack-khoaitay-tao-ngot.png");
            this.imgLarge.Images.SetKeyName(18, "snack-vi-cua.jpg");
            this.imgLarge.Images.SetKeyName(19, "cafedenda.jpg");
            this.imgLarge.Images.SetKeyName(20, "cafe-sua-nong.jpg");
            this.imgLarge.Images.SetKeyName(21, "Cafe-Sua.jpg");
            this.imgLarge.Images.SetKeyName(22, "c2-truyenthong.jpg");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(271, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(971, 246);
            this.panel3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(355, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(406, 40);
            this.label5.TabIndex = 7;
            this.label5.Text = "Thông tin chi tiết thức ăn ";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txbNameFood);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(503, 79);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(454, 58);
            this.panel7.TabIndex = 2;
            // 
            // txbNameFood
            // 
            this.txbNameFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNameFood.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameFood.Location = new System.Drawing.Point(186, 10);
            this.txbNameFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNameFood.Name = "txbNameFood";
            this.txbNameFood.Size = new System.Drawing.Size(247, 40);
            this.txbNameFood.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên món ăn:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.nudPrice);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(503, 172);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(454, 58);
            this.panel6.TabIndex = 3;
            // 
            // nudPrice
            // 
            this.nudPrice.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrice.Location = new System.Drawing.Point(185, 10);
            this.nudPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(247, 40);
            this.nudPrice.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbbFood);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(17, 172);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(455, 58);
            this.panel5.TabIndex = 2;
            // 
            // cbbFood
            // 
            this.cbbFood.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFood.FormattingEnabled = true;
            this.cbbFood.Items.AddRange(new object[] {
            "Quản lý ",
            "Nhân viên"});
            this.cbbFood.Location = new System.Drawing.Point(186, 9);
            this.cbbFood.Name = "cbbFood";
            this.cbbFood.Size = new System.Drawing.Size(247, 41);
            this.cbbFood.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh mục:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbID);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(17, 79);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(454, 58);
            this.panel4.TabIndex = 1;
            // 
            // txbID
            // 
            this.txbID.BackColor = System.Drawing.SystemColors.Control;
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
            // panel8
            // 
            this.panel8.Controls.Add(this.btnAdd);
            this.panel8.Controls.Add(this.btnUpdate);
            this.panel8.Controls.Add(this.btnDelete);
            this.panel8.Location = new System.Drawing.Point(1248, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(214, 246);
            this.panel8.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(45, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 52);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(45, 97);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 52);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(45, 178);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 52);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // adminFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 696);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "adminFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminFood";
            this.Load += new System.EventHandler(this.adminFood_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tvCategoryFood;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvFood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbNameFood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbbFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.ImageList imgLCategory;
        private System.Windows.Forms.ImageList imgLarge;
    }
}