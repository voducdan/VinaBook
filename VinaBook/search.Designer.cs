namespace VinaBook
{
    partial class search
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.cart = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.returnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 246);
            this.dataGridView1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kết quả tìm kiếm";
            // 
            // signUpBtn
            // 
            this.signUpBtn.Location = new System.Drawing.Point(715, 14);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(75, 23);
            this.signUpBtn.TabIndex = 13;
            this.signUpBtn.Text = "Đăng Ký";
            this.signUpBtn.UseVisualStyleBackColor = true;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(634, 14);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 12;
            this.loginBtn.Text = "Đăng nhập";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // cart
            // 
            this.cart.Location = new System.Drawing.Point(536, 14);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(75, 23);
            this.cart.TabIndex = 11;
            this.cart.Text = "Giỏ hàng";
            this.cart.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(414, 14);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(244, 15);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(164, 20);
            this.searchInput.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "VinaBook";
            // 
            // returnHome
            // 
            this.returnHome.Location = new System.Drawing.Point(712, 62);
            this.returnHome.Name = "returnHome";
            this.returnHome.Size = new System.Drawing.Size(75, 23);
            this.returnHome.TabIndex = 14;
            this.returnHome.Text = "Trang chủ";
            this.returnHome.UseVisualStyleBackColor = true;
            this.returnHome.Click += new System.EventHandler(this.returnHome_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnHome);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.cart);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button cart;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnHome;
    }
}
