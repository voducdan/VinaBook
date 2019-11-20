namespace VinaBook
{
    partial class Home
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
            this.searchInput = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.cart = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.typeOfBook = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.danhmuc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "VinaBook";
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(242, 21);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(164, 20);
            this.searchInput.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(412, 20);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // cart
            // 
            this.cart.Location = new System.Drawing.Point(534, 20);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(75, 23);
            this.cart.TabIndex = 3;
            this.cart.Text = "Giỏ hàng";
            this.cart.UseVisualStyleBackColor = true;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(632, 20);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Đăng nhập";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // signUpBtn
            // 
            this.signUpBtn.Location = new System.Drawing.Point(713, 20);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(75, 23);
            this.signUpBtn.TabIndex = 5;
            this.signUpBtn.Text = "Đăng Ký";
            this.signUpBtn.UseVisualStyleBackColor = true;
            // 
            // typeOfBook
            // 
            this.typeOfBook.FormattingEnabled = true;
            this.typeOfBook.Items.AddRange(new object[] {
            "Sách ngoại văn",
            "Sách kinh tế",
            "Sách văn học trong nước",
            "Sách văn học nước ngoài",
            "Sách thiếu nhi",
            "Sách thường thức đời sống",
            "Sách phát triển bản thân",
            "Sách tin học ngoại ngữ",
            "Sách giáo khoa",
            "Sách chuyên ngành",
            "Sách văn phòng phẩm"});
            this.typeOfBook.Location = new System.Drawing.Point(18, 58);
            this.typeOfBook.Name = "typeOfBook";
            this.typeOfBook.Size = new System.Drawing.Size(139, 21);
            this.typeOfBook.TabIndex = 6;
            this.typeOfBook.Text = "Chọn một thể loại sách";
            this.typeOfBook.SelectedIndexChanged += new System.EventHandler(this.typeOfBook_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(910, 353);
            this.dataGridView1.TabIndex = 7;
            // 
            // danhmuc
            // 
            this.danhmuc.BackColor = System.Drawing.SystemColors.Window;
            this.danhmuc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.danhmuc.FormattingEnabled = true;
            this.danhmuc.Location = new System.Drawing.Point(177, 58);
            this.danhmuc.Name = "danhmuc";
            this.danhmuc.Size = new System.Drawing.Size(121, 21);
            this.danhmuc.TabIndex = 8;
            this.danhmuc.Text = "Chọn danh mục";
            this.danhmuc.SelectedIndexChanged += new System.EventHandler(this.danhmuc_SelectedIndexChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.danhmuc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.typeOfBook);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.cart);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button cart;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.ComboBox typeOfBook;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox danhmuc;
    }
}