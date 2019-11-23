namespace VinaBook
{
    partial class payment
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
            this.label2 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.continueBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bocsach = new System.Windows.Forms.CheckBox();
            this.goiqua = new System.Windows.Forms.CheckBox();
            this.xuathoadon = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.quan = new System.Windows.Forms.TextBox();
            this.magiamgia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ghichugiaohang = new System.Windows.Forms.RichTextBox();
            this.phuongthucthanhtoan = new System.Windows.Forms.ComboBox();
            this.sothe = new System.Windows.Forms.TextBox();
            this.sothelable = new System.Windows.Forms.Label();
            this.phuong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thông tin thanh toán";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Snow;
            this.back.Location = new System.Drawing.Point(215, 399);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(180, 39);
            this.back.TabIndex = 20;
            this.back.Text = "Quay lại";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // continueBtn
            // 
            this.continueBtn.BackColor = System.Drawing.Color.Yellow;
            this.continueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueBtn.ForeColor = System.Drawing.Color.Black;
            this.continueBtn.Location = new System.Drawing.Point(448, 399);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(188, 39);
            this.continueBtn.TabIndex = 21;
            this.continueBtn.Text = "Tiếp tục";
            this.continueBtn.UseVisualStyleBackColor = false;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(657, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dịch vụ kèm theo";
            // 
            // bocsach
            // 
            this.bocsach.AutoSize = true;
            this.bocsach.Location = new System.Drawing.Point(657, 85);
            this.bocsach.Name = "bocsach";
            this.bocsach.Size = new System.Drawing.Size(145, 17);
            this.bocsach.TabIndex = 17;
            this.bocsach.Text = "Bọc sách (3000đ/quyển)";
            this.bocsach.UseVisualStyleBackColor = true;
            // 
            // goiqua
            // 
            this.goiqua.AutoSize = true;
            this.goiqua.Location = new System.Drawing.Point(657, 108);
            this.goiqua.Name = "goiqua";
            this.goiqua.Size = new System.Drawing.Size(106, 17);
            this.goiqua.TabIndex = 18;
            this.goiqua.Text = "Gói quà(10000đ)";
            this.goiqua.UseVisualStyleBackColor = true;
            // 
            // xuathoadon
            // 
            this.xuathoadon.AutoSize = true;
            this.xuathoadon.Location = new System.Drawing.Point(657, 131);
            this.xuathoadon.Name = "xuathoadon";
            this.xuathoadon.Size = new System.Drawing.Size(139, 17);
            this.xuathoadon.TabIndex = 19;
            this.xuathoadon.Text = "Xuất hoá đơn(Miễn phí)";
            this.xuathoadon.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ giao hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Họ và Tên*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Điện thoại*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tỉnh*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Quận*";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(79, 80);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(158, 20);
            this.name.TabIndex = 9;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(79, 113);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(158, 20);
            this.phone.TabIndex = 10;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(79, 148);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(158, 20);
            this.city.TabIndex = 11;
            // 
            // quan
            // 
            this.quan.Location = new System.Drawing.Point(79, 179);
            this.quan.Name = "quan";
            this.quan.Size = new System.Drawing.Size(158, 20);
            this.quan.TabIndex = 12;
            // 
            // magiamgia
            // 
            this.magiamgia.Location = new System.Drawing.Point(287, 77);
            this.magiamgia.Name = "magiamgia";
            this.magiamgia.Size = new System.Drawing.Size(176, 20);
            this.magiamgia.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(283, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Mã giảm giá";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(283, 111);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(180, 20);
            this.t.TabIndex = 24;
            this.t.Text = "Phương thức thanh toán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ghi chú giao hàng";
            // 
            // ghichugiaohang
            // 
            this.ghichugiaohang.Location = new System.Drawing.Point(493, 84);
            this.ghichugiaohang.Name = "ghichugiaohang";
            this.ghichugiaohang.Size = new System.Drawing.Size(134, 96);
            this.ghichugiaohang.TabIndex = 28;
            this.ghichugiaohang.Text = "";
            // 
            // phuongthucthanhtoan
            // 
            this.phuongthucthanhtoan.FormattingEnabled = true;
            this.phuongthucthanhtoan.Items.AddRange(new object[] {
            "Master Card",
            "Payoo",
            "Visa",
            "ATM nội địa",
            "JCB",
            "Tiền mặt"});
            this.phuongthucthanhtoan.Location = new System.Drawing.Point(287, 143);
            this.phuongthucthanhtoan.Name = "phuongthucthanhtoan";
            this.phuongthucthanhtoan.Size = new System.Drawing.Size(176, 21);
            this.phuongthucthanhtoan.TabIndex = 29;
            this.phuongthucthanhtoan.Text = "Phương thức thanh toán";
            this.phuongthucthanhtoan.SelectedIndexChanged += new System.EventHandler(this.phuongthucthanhtoan_SelectedIndexChanged);
            // 
            // sothe
            // 
            this.sothe.Location = new System.Drawing.Point(287, 203);
            this.sothe.Name = "sothe";
            this.sothe.Size = new System.Drawing.Size(176, 20);
            this.sothe.TabIndex = 30;
            // 
            // sothelable
            // 
            this.sothelable.AutoSize = true;
            this.sothelable.Location = new System.Drawing.Point(284, 179);
            this.sothelable.Name = "sothelable";
            this.sothelable.Size = new System.Drawing.Size(38, 13);
            this.sothelable.TabIndex = 31;
            this.sothelable.Text = "Số thẻ";
            // 
            // phuong
            // 
            this.phuong.Location = new System.Drawing.Point(79, 212);
            this.phuong.Name = "phuong";
            this.phuong.Size = new System.Drawing.Size(158, 20);
            this.phuong.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Phường";
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.phuong);
            this.Controls.Add(this.sothelable);
            this.Controls.Add(this.sothe);
            this.Controls.Add(this.phuongthucthanhtoan);
            this.Controls.Add(this.ghichugiaohang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.magiamgia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bocsach);
            this.Controls.Add(this.goiqua);
            this.Controls.Add(this.xuathoadon);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.city);
            this.Controls.Add(this.quan);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Name = "payment";
            this.Text = "payment";
            this.Load += new System.EventHandler(this.payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox bocsach;
        private System.Windows.Forms.CheckBox goiqua;
        private System.Windows.Forms.CheckBox xuathoadon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox quan;
        private System.Windows.Forms.TextBox magiamgia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ghichugiaohang;
        private System.Windows.Forms.ComboBox phuongthucthanhtoan;
        private System.Windows.Forms.TextBox sothe;
        private System.Windows.Forms.Label sothelable;
        private System.Windows.Forms.TextBox phuong;
        private System.Windows.Forms.Label label11;
    }
}