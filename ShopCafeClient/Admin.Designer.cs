using System.Windows.Forms;

namespace ShopCafeClient
{
    partial class Admin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tgBill = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.tgFood = new System.Windows.Forms.TabPage();
            this.tgCategory = new System.Windows.Forms.TabPage();
            this.tgDesk = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tgBill.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tgBill);
            this.tabControl1.Controls.Add(this.tgFood);
            this.tabControl1.Controls.Add(this.tgCategory);
            this.tabControl1.Controls.Add(this.tgDesk);
            this.tabControl1.Location = new System.Drawing.Point(13, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 494);
            this.tabControl1.TabIndex = 0;
            // 
            // tgBill
            // 
            this.tgBill.Controls.Add(this.panel2);
            this.tgBill.Controls.Add(this.panel1);
            this.tgBill.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tgBill.Location = new System.Drawing.Point(4, 25);
            this.tgBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tgBill.Name = "tgBill";
            this.tgBill.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tgBill.Size = new System.Drawing.Size(767, 465);
            this.tgBill.TabIndex = 0;
            this.tgBill.Text = "Doanh thu";
            this.tgBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(13, 79);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 370);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(729, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnViewBill);
            this.panel1.Controls.Add(this.dtpCheckOut);
            this.panel1.Controls.Add(this.dtpCheckIn);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 49);
            this.panel1.TabIndex = 0;
            // 
            // btnViewBill
            // 
            this.btnViewBill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewBill.Location = new System.Drawing.Point(310, 13);
            this.btnViewBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(131, 30);
            this.btnViewBill.TabIndex = 2;
            this.btnViewBill.Text = "Thống kê";
            this.btnViewBill.UseVisualStyleBackColor = true;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(447, 13);
            this.dtpCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(285, 30);
            this.dtpCheckOut.TabIndex = 1;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(19, 13);
            this.dtpCheckIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(285, 30);
            this.dtpCheckIn.TabIndex = 0;
            // 
            // tgFood
            // 
            this.tgFood.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tgFood.Location = new System.Drawing.Point(4, 25);
            this.tgFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tgFood.Name = "tgFood";
            this.tgFood.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tgFood.Size = new System.Drawing.Size(767, 465);
            this.tgFood.TabIndex = 1;
            this.tgFood.Text = "Thức ăn";
            this.tgFood.UseVisualStyleBackColor = true;
            // 
            // tgCategory
            // 
            this.tgCategory.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tgCategory.Location = new System.Drawing.Point(4, 25);
            this.tgCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tgCategory.Name = "tgCategory";
            this.tgCategory.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tgCategory.Size = new System.Drawing.Size(767, 465);
            this.tgCategory.TabIndex = 2;
            this.tgCategory.Text = "Danh mục";
            this.tgCategory.UseVisualStyleBackColor = true;
            // 
            // tgDesk
            // 
            this.tgDesk.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tgDesk.Location = new System.Drawing.Point(4, 25);
            this.tgDesk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tgDesk.Name = "tgDesk";
            this.tgDesk.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tgDesk.Size = new System.Drawing.Size(767, 465);
            this.tgDesk.TabIndex = 3;
            this.tgDesk.Text = "Bàn ăn";
            this.tgDesk.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.tabControl1.ResumeLayout(false);
            this.tgBill.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tgBill;
        private TabPage tgFood;
        private TabPage tgCategory;
        private TabPage tgDesk;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btnViewBill;
        private DateTimePicker dtpCheckOut;
        private DateTimePicker dtpCheckIn;
    }
}