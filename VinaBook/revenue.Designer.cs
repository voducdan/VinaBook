namespace VinaBook
{
    partial class revenue
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
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRevenueYear = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.viewRevenueYear = new System.Windows.Forms.DataGridView();
            this.tabRevenueAgency = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.viewRevenueAgency = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabRevenueYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewRevenueYear)).BeginInit();
            this.tabRevenueAgency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewRevenueAgency)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "VinaBook";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Doanh thu";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRevenueYear);
            this.tabControl1.Controls.Add(this.tabRevenueAgency);
            this.tabControl1.Location = new System.Drawing.Point(18, 112);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 367);
            this.tabControl1.TabIndex = 12;
            // 
            // tabRevenueYear
            // 
            this.tabRevenueYear.Controls.Add(this.button1);
            this.tabRevenueYear.Controls.Add(this.viewRevenueYear);
            this.tabRevenueYear.Location = new System.Drawing.Point(4, 22);
            this.tabRevenueYear.Name = "tabRevenueYear";
            this.tabRevenueYear.Padding = new System.Windows.Forms.Padding(3);
            this.tabRevenueYear.Size = new System.Drawing.Size(762, 341);
            this.tabRevenueYear.TabIndex = 0;
            this.tabRevenueYear.Text = "Theo năm";
            this.tabRevenueYear.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewRevenueYear
            // 
            this.viewRevenueYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewRevenueYear.Location = new System.Drawing.Point(7, 7);
            this.viewRevenueYear.Name = "viewRevenueYear";
            this.viewRevenueYear.Size = new System.Drawing.Size(749, 287);
            this.viewRevenueYear.TabIndex = 0;
            // 
            // tabRevenueAgency
            // 
            this.tabRevenueAgency.Controls.Add(this.button2);
            this.tabRevenueAgency.Controls.Add(this.viewRevenueAgency);
            this.tabRevenueAgency.Location = new System.Drawing.Point(4, 22);
            this.tabRevenueAgency.Name = "tabRevenueAgency";
            this.tabRevenueAgency.Padding = new System.Windows.Forms.Padding(3);
            this.tabRevenueAgency.Size = new System.Drawing.Size(762, 341);
            this.tabRevenueAgency.TabIndex = 1;
            this.tabRevenueAgency.Text = "Đại lý";
            this.tabRevenueAgency.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // viewRevenueAgency
            // 
            this.viewRevenueAgency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewRevenueAgency.Location = new System.Drawing.Point(7, 7);
            this.viewRevenueAgency.Name = "viewRevenueAgency";
            this.viewRevenueAgency.Size = new System.Drawing.Size(749, 287);
            this.viewRevenueAgency.TabIndex = 0;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(703, 105);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 13;
            this.back.Text = "Quay lại";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 561);
            this.Controls.Add(this.back);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "revenue";
            this.Text = "revenue";
            this.tabControl1.ResumeLayout(false);
            this.tabRevenueYear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewRevenueYear)).EndInit();
            this.tabRevenueAgency.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewRevenueAgency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRevenueYear;
        private System.Windows.Forms.DataGridView viewRevenueYear;
        private System.Windows.Forms.TabPage tabRevenueAgency;
        private System.Windows.Forms.DataGridView viewRevenueAgency;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button back;
    }
}