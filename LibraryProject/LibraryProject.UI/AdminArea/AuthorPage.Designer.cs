namespace LibraryProject.UI.AdminArea
{
    partial class AuthorPage
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
            this.txtCreateLastName = new System.Windows.Forms.TextBox();
            this.txtCreateFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(782, 310);
            this.dataGridView1.TabIndex = 3;
            // 
            // grpCreate
            // 
            this.grpCreate.Controls.Add(this.btnCreate);
            this.grpCreate.Controls.Add(this.txtCreateLastName);
            this.grpCreate.Controls.Add(this.txtCreateFirstName);
            this.grpCreate.Controls.Add(this.label2);
            this.grpCreate.Controls.Add(this.label1);
            this.grpCreate.Location = new System.Drawing.Point(12, 11);
            this.grpCreate.Name = "grpCreate";
            this.grpCreate.Size = new System.Drawing.Size(261, 165);
            this.grpCreate.TabIndex = 2;
            this.grpCreate.TabStop = false;
            this.grpCreate.Text = "Create Author";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(165, 112);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(80, 31);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCreateLastName
            // 
            this.txtCreateLastName.Location = new System.Drawing.Point(122, 80);
            this.txtCreateLastName.Name = "txtCreateLastName";
            this.txtCreateLastName.Size = new System.Drawing.Size(123, 20);
            this.txtCreateLastName.TabIndex = 1;
            // 
            // txtCreateFirstName
            // 
            this.txtCreateFirstName.Location = new System.Drawing.Point(122, 40);
            this.txtCreateFirstName.Name = "txtCreateFirstName";
            this.txtCreateFirstName.Size = new System.Drawing.Size(123, 20);
            this.txtCreateFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // AuthorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 575);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpCreate);
            this.Name = "AuthorPage";
            this.Text = "AuthorPage";
            this.Load += new System.EventHandler(this.AuthorPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpCreate.ResumeLayout(false);
            this.grpCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpCreate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtCreateLastName;
        private System.Windows.Forms.TextBox txtCreateFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}