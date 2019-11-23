namespace VinaBook
{
    partial class System_Admin
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
            this.AgencyBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffBtn = new System.Windows.Forms.Button();
            this.searchStaffBtn = new System.Windows.Forms.Button();
            this.searchStaff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.revenueBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.warehouseBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AgencyBtn
            // 
            this.AgencyBtn.Location = new System.Drawing.Point(12, 105);
            this.AgencyBtn.Name = "AgencyBtn";
            this.AgencyBtn.Size = new System.Drawing.Size(75, 23);
            this.AgencyBtn.TabIndex = 0;
            this.AgencyBtn.Text = "Đại lý";
            this.AgencyBtn.UseVisualStyleBackColor = true;
            this.AgencyBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "VinaBook";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(964, 464);
            this.dataGridView1.TabIndex = 10;
            // 
            // staffBtn
            // 
            this.staffBtn.Location = new System.Drawing.Point(159, 105);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(75, 23);
            this.staffBtn.TabIndex = 11;
            this.staffBtn.Text = "Nhân viên";
            this.staffBtn.UseVisualStyleBackColor = true;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // searchStaffBtn
            // 
            this.searchStaffBtn.Location = new System.Drawing.Point(520, 105);
            this.searchStaffBtn.Name = "searchStaffBtn";
            this.searchStaffBtn.Size = new System.Drawing.Size(95, 23);
            this.searchStaffBtn.TabIndex = 12;
            this.searchStaffBtn.Text = "Tìm nhân viên";
            this.searchStaffBtn.UseVisualStyleBackColor = true;
            this.searchStaffBtn.Click += new System.EventHandler(this.searchStaffBtn_Click);
            // 
            // searchStaff
            // 
            this.searchStaff.Location = new System.Drawing.Point(367, 107);
            this.searchStaff.Name = "searchStaff";
            this.searchStaff.Size = new System.Drawing.Size(147, 20);
            this.searchStaff.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(292, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nhập tên: ";
            // 
            // revenueBtn
            // 
            this.revenueBtn.Location = new System.Drawing.Point(895, 106);
            this.revenueBtn.Name = "revenueBtn";
            this.revenueBtn.Size = new System.Drawing.Size(75, 23);
            this.revenueBtn.TabIndex = 15;
            this.revenueBtn.Text = "Doanh thu";
            this.revenueBtn.UseVisualStyleBackColor = true;
            this.revenueBtn.Click += new System.EventHandler(this.revenueBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 31);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quản lý";
            // 
            // warehouseBtn
            // 
            this.warehouseBtn.Location = new System.Drawing.Point(650, 106);
            this.warehouseBtn.Name = "warehouseBtn";
            this.warehouseBtn.Size = new System.Drawing.Size(75, 23);
            this.warehouseBtn.TabIndex = 17;
            this.warehouseBtn.Text = "Kho";
            this.warehouseBtn.UseVisualStyleBackColor = true;
            this.warehouseBtn.Click += new System.EventHandler(this.warehouseBtn_Click);
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(764, 105);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(75, 23);
            this.orderBtn.TabIndex = 18;
            this.orderBtn.Text = "Đơn hàng";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // System_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 610);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.warehouseBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.revenueBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchStaff);
            this.Controls.Add(this.searchStaffBtn);
            this.Controls.Add(this.staffBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgencyBtn);
            this.Name = "System_Admin";
            this.Text = "System_Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgencyBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button staffBtn;
        private System.Windows.Forms.Button searchStaffBtn;
        private System.Windows.Forms.TextBox searchStaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button revenueBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button warehouseBtn;
        private System.Windows.Forms.Button orderBtn;
    }
}