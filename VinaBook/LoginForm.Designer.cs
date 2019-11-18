namespace VinaBook
{
    partial class LoginForm
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
            this.loginTitle = new System.Windows.Forms.Label();
            this.unameInput = new System.Windows.Forms.Label();
            this.pwdInput = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginTitle
            // 
            this.loginTitle.AutoSize = true;
            this.loginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitle.Location = new System.Drawing.Point(297, 70);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(203, 31);
            this.loginTitle.TabIndex = 0;
            this.loginTitle.Text = "VinaBook Login";
            this.loginTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // unameInput
            // 
            this.unameInput.AutoSize = true;
            this.unameInput.Location = new System.Drawing.Point(297, 165);
            this.unameInput.Name = "unameInput";
            this.unameInput.Size = new System.Drawing.Size(55, 13);
            this.unameInput.TabIndex = 1;
            this.unameInput.Text = "Username";
            // 
            // pwdInput
            // 
            this.pwdInput.AutoSize = true;
            this.pwdInput.Location = new System.Drawing.Point(297, 207);
            this.pwdInput.Name = "pwdInput";
            this.pwdInput.Size = new System.Drawing.Size(53, 13);
            this.pwdInput.TabIndex = 2;
            this.pwdInput.Text = "Password";
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(397, 162);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(100, 20);
            this.uname.TabIndex = 3;
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(397, 204);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(100, 20);
            this.pwd.TabIndex = 4;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginBtn.Location = new System.Drawing.Point(303, 269);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(194, 23);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.pwdInput);
            this.Controls.Add(this.unameInput);
            this.Controls.Add(this.loginTitle);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label loginTitle;
        private System.Windows.Forms.Label unameInput;
        private System.Windows.Forms.Label pwdInput;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Button loginBtn;
    }
}

