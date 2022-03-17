namespace LibraryProject.UI
{
    partial class LoginPage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpSignIn = new System.Windows.Forms.GroupBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSignIn
            // 
            this.grpSignIn.Controls.Add(this.btnSignIn);
            this.grpSignIn.Controls.Add(this.txtPassword);
            this.grpSignIn.Controls.Add(this.txtUserName);
            this.grpSignIn.Controls.Add(this.label2);
            this.grpSignIn.Controls.Add(this.label1);
            this.grpSignIn.Location = new System.Drawing.Point(266, 103);
            this.grpSignIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSignIn.Name = "grpSignIn";
            this.grpSignIn.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSignIn.Size = new System.Drawing.Size(269, 244);
            this.grpSignIn.TabIndex = 1;
            this.grpSignIn.TabStop = false;
            this.grpSignIn.Text = "Sign In";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(157, 172);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(84, 30);
            this.btnSignIn.TabIndex = 3;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(40, 140);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(201, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(40, 76);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(201, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpSignIn);
            this.Name = "LoginPage";
            this.Text = "Login Page";
            this.grpSignIn.ResumeLayout(false);
            this.grpSignIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSignIn;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

