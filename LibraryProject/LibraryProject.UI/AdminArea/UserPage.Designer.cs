namespace LibraryProject.UI.AdminArea
{
    partial class UserPage
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
            this.grpCreate = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cmbCreateRole = new System.Windows.Forms.ComboBox();
            this.txtCreatePassword = new System.Windows.Forms.TextBox();
            this.txtCreateUserName = new System.Windows.Forms.TextBox();
            this.txtCreateLastName = new System.Windows.Forms.TextBox();
            this.txtCreateFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 375);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(914, 200);
            this.dataGridView1.TabIndex = 3;
            // 
            // grpCreate
            // 
            this.grpCreate.Controls.Add(this.btnCreate);
            this.grpCreate.Controls.Add(this.cmbCreateRole);
            this.grpCreate.Controls.Add(this.txtCreatePassword);
            this.grpCreate.Controls.Add(this.txtCreateUserName);
            this.grpCreate.Controls.Add(this.txtCreateLastName);
            this.grpCreate.Controls.Add(this.txtCreateFirstName);
            this.grpCreate.Controls.Add(this.label5);
            this.grpCreate.Controls.Add(this.label4);
            this.grpCreate.Controls.Add(this.label3);
            this.grpCreate.Controls.Add(this.label2);
            this.grpCreate.Controls.Add(this.label1);
            this.grpCreate.Location = new System.Drawing.Point(12, 12);
            this.grpCreate.Name = "grpCreate";
            this.grpCreate.Size = new System.Drawing.Size(257, 364);
            this.grpCreate.TabIndex = 2;
            this.grpCreate.TabStop = false;
            this.grpCreate.Text = "Create User";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(146, 326);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(81, 33);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cmbCreateRole
            // 
            this.cmbCreateRole.FormattingEnabled = true;
            this.cmbCreateRole.Location = new System.Drawing.Point(30, 292);
            this.cmbCreateRole.Name = "cmbCreateRole";
            this.cmbCreateRole.Size = new System.Drawing.Size(197, 21);
            this.cmbCreateRole.TabIndex = 2;
            // 
            // txtCreatePassword
            // 
            this.txtCreatePassword.Location = new System.Drawing.Point(30, 231);
            this.txtCreatePassword.Name = "txtCreatePassword";
            this.txtCreatePassword.Size = new System.Drawing.Size(197, 20);
            this.txtCreatePassword.TabIndex = 1;
            // 
            // txtCreateUserName
            // 
            this.txtCreateUserName.Location = new System.Drawing.Point(30, 180);
            this.txtCreateUserName.Name = "txtCreateUserName";
            this.txtCreateUserName.Size = new System.Drawing.Size(197, 20);
            this.txtCreateUserName.TabIndex = 1;
            // 
            // txtCreateLastName
            // 
            this.txtCreateLastName.Location = new System.Drawing.Point(30, 125);
            this.txtCreateLastName.Name = "txtCreateLastName";
            this.txtCreateLastName.Size = new System.Drawing.Size(197, 20);
            this.txtCreateLastName.TabIndex = 1;
            // 
            // txtCreateFirstName
            // 
            this.txtCreateFirstName.Location = new System.Drawing.Point(30, 67);
            this.txtCreateFirstName.Name = "txtCreateFirstName";
            this.txtCreateFirstName.Size = new System.Drawing.Size(197, 20);
            this.txtCreateFirstName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Role:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 587);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpCreate);
            this.Name = "UserPage";
            this.Text = "UserPage";
            this.Load += new System.EventHandler(this.UserPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpCreate.ResumeLayout(false);
            this.grpCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpCreate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cmbCreateRole;
        private System.Windows.Forms.TextBox txtCreatePassword;
        private System.Windows.Forms.TextBox txtCreateUserName;
        private System.Windows.Forms.TextBox txtCreateLastName;
        private System.Windows.Forms.TextBox txtCreateFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}