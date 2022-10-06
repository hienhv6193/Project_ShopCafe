using System.Windows.Forms;

namespace ShopCafeClient
{
    partial class Manager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1260, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem1,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinCáNhânToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // thôngTinCáNhânToolStripMenuItem1
            // 
            this.thôngTinCáNhânToolStripMenuItem1.Name = "thôngTinCáNhânToolStripMenuItem1";
            this.thôngTinCáNhânToolStripMenuItem1.Size = new System.Drawing.Size(232, 26);
            this.thôngTinCáNhânToolStripMenuItem1.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem1.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem1_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.cbbCategory);
            this.panel2.Location = new System.Drawing.Point(715, 40);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 64);
            this.panel2.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(459, 22);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(51, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(320, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(6, 6);
            this.cbbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(320, 24);
            this.cbbCategory.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lsvBill);
            this.panel3.Location = new System.Drawing.Point(715, 117);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(530, 350);
            this.panel3.TabIndex = 3;
            // 
            // lsvBill
            // 
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(3, 2);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(524, 346);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(715, 472);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(530, 52);
            this.panel4.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 40);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(687, 484);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(332, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thêm món";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 534);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cafe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem1;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel2;
        private ComboBox comboBox1;
        private ComboBox cbbCategory;
        private Panel panel3;
        private ListView lsvBill;
        private Panel panel4;
        private NumericUpDown numericUpDown1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
    }
}