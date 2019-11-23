namespace VinaBook
{
    partial class Cart
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sum = new System.Windows.Forms.GroupBox();
            this.totalDue = new System.Windows.Forms.Label();
            this.transportFee = new System.Windows.Forms.Label();
            this.numOfBook = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.pay = new System.Windows.Forms.Button();
            this.decBtn = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.Button();
            this.incBtn = new System.Windows.Forms.Button();
            this.delBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.sum.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "VinaBook";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giỏ hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sum
            // 
            this.sum.Controls.Add(this.totalDue);
            this.sum.Controls.Add(this.transportFee);
            this.sum.Controls.Add(this.numOfBook);
            this.sum.Controls.Add(this.label6);
            this.sum.Controls.Add(this.label4);
            this.sum.Controls.Add(this.label3);
            this.sum.Location = new System.Drawing.Point(720, 100);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(200, 154);
            this.sum.TabIndex = 3;
            this.sum.TabStop = false;
            this.sum.Text = "Tóm tắt đơn hàng";
            // 
            // totalDue
            // 
            this.totalDue.AutoSize = true;
            this.totalDue.Location = new System.Drawing.Point(135, 85);
            this.totalDue.Name = "totalDue";
            this.totalDue.Size = new System.Drawing.Size(0, 13);
            this.totalDue.TabIndex = 6;
            // 
            // transportFee
            // 
            this.transportFee.AutoSize = true;
            this.transportFee.Location = new System.Drawing.Point(111, 60);
            this.transportFee.Name = "transportFee";
            this.transportFee.Size = new System.Drawing.Size(0, 13);
            this.transportFee.TabIndex = 5;
            // 
            // numOfBook
            // 
            this.numOfBook.AutoSize = true;
            this.numOfBook.Location = new System.Drawing.Point(139, 35);
            this.numOfBook.Name = "numOfBook";
            this.numOfBook.Size = new System.Drawing.Size(0, 13);
            this.numOfBook.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tổng cộng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Phí vận chuyển";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sản phẩm";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Snow;
            this.back.Location = new System.Drawing.Point(260, 364);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(180, 39);
            this.back.TabIndex = 4;
            this.back.Text = "Quay lại";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pay
            // 
            this.pay.BackColor = System.Drawing.Color.Yellow;
            this.pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay.ForeColor = System.Drawing.Color.Black;
            this.pay.Location = new System.Drawing.Point(478, 364);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(188, 39);
            this.pay.TabIndex = 5;
            this.pay.Text = "Thanh toán";
            this.pay.UseVisualStyleBackColor = false;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // decBtn
            // 
            this.decBtn.Location = new System.Drawing.Point(510, 256);
            this.decBtn.Name = "decBtn";
            this.decBtn.Size = new System.Drawing.Size(29, 23);
            this.decBtn.TabIndex = 6;
            this.decBtn.Text = "-";
            this.decBtn.UseVisualStyleBackColor = true;
            this.decBtn.Click += new System.EventHandler(this.decBtn_Click);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(545, 256);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(29, 23);
            this.quantity.TabIndex = 7;
            this.quantity.UseVisualStyleBackColor = true;
            // 
            // incBtn
            // 
            this.incBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incBtn.Location = new System.Drawing.Point(580, 256);
            this.incBtn.Name = "incBtn";
            this.incBtn.Size = new System.Drawing.Size(29, 23);
            this.incBtn.TabIndex = 8;
            this.incBtn.Text = "+";
            this.incBtn.UseVisualStyleBackColor = true;
            this.incBtn.Click += new System.EventHandler(this.incBtn_Click);
            // 
            // delBook
            // 
            this.delBook.Location = new System.Drawing.Point(615, 256);
            this.delBook.Name = "delBook";
            this.delBook.Size = new System.Drawing.Size(41, 23);
            this.delBook.TabIndex = 9;
            this.delBook.Text = "Xoá";
            this.delBook.UseVisualStyleBackColor = true;
            this.delBook.Click += new System.EventHandler(this.delBook_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 474);
            this.Controls.Add(this.delBook);
            this.Controls.Add(this.incBtn);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.decBtn);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.back);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.sum.ResumeLayout(false);
            this.sum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox sum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label transportFee;
        private System.Windows.Forms.Label numOfBook;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.Button decBtn;
        private System.Windows.Forms.Button quantity;
        private System.Windows.Forms.Button incBtn;
        private System.Windows.Forms.Button delBook;
        private System.Windows.Forms.Label totalDue;
    }
}