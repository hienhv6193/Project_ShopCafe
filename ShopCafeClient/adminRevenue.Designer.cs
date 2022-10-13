using System.Windows.Forms;

namespace ShopCafeClient
{
    partial class adminRevenue
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
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.btnViewBill = new System.Windows.Forms.Button();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Location = new System.Drawing.Point(12, 64);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowHeadersWidth = 51;
            this.dgvDoanhThu.RowTemplate.Height = 24;
            this.dgvDoanhThu.Size = new System.Drawing.Size(799, 442);
            this.dgvDoanhThu.TabIndex = 0;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.Location = new System.Drawing.Point(12, 11);
            this.dtpCheckIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(307, 30);
            this.dtpCheckIn.TabIndex = 1;
            // 
            // btnViewBill
            // 
            this.btnViewBill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewBill.Location = new System.Drawing.Point(352, 11);
            this.btnViewBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.Size = new System.Drawing.Size(123, 39);
            this.btnViewBill.TabIndex = 3;
            this.btnViewBill.Text = "Thống kê";
            this.btnViewBill.UseVisualStyleBackColor = true;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.Location = new System.Drawing.Point(501, 11);
            this.dtpCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(310, 30);
            this.dtpCheckOut.TabIndex = 4;
            // 
            // adminRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 518);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.btnViewBill);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.dgvDoanhThu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "adminRevenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh thu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvDoanhThu;
        private DateTimePicker dtpCheckIn;
        private Button btnViewBill;
        private DateTimePicker dtpCheckOut;
    }
}