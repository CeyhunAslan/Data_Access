namespace LibraryProject.UI.AdminArea
{
    partial class CategoryPage
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
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFindById = new System.Windows.Forms.Button();
            this.txtFindById = new System.Windows.Forms.TextBox();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpCreate = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtCreateName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpDelete.SuspendLayout();
            this.grpUpdate.SuspendLayout();
            this.grpCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1003, 386);
            this.dataGridView1.TabIndex = 5;
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.btnDelete);
            this.grpDelete.Controls.Add(this.txtDelete);
            this.grpDelete.Controls.Add(this.label4);
            this.grpDelete.Location = new System.Drawing.Point(544, 5);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(206, 85);
            this.grpDelete.TabIndex = 2;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "Delete Category";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(102, 39);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 28);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(55, 39);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(41, 20);
            this.txtDelete.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Id:";
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.btnUpdate);
            this.grpUpdate.Controls.Add(this.btnFindById);
            this.grpUpdate.Controls.Add(this.txtFindById);
            this.grpUpdate.Controls.Add(this.txtUpdateName);
            this.grpUpdate.Controls.Add(this.label3);
            this.grpUpdate.Controls.Add(this.label2);
            this.grpUpdate.Location = new System.Drawing.Point(278, 5);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(260, 162);
            this.grpUpdate.TabIndex = 3;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Update Category";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(139, 111);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 28);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnFindById
            // 
            this.btnFindById.Location = new System.Drawing.Point(139, 42);
            this.btnFindById.Name = "btnFindById";
            this.btnFindById.Size = new System.Drawing.Size(81, 28);
            this.btnFindById.TabIndex = 2;
            this.btnFindById.Text = "Find";
            this.btnFindById.UseVisualStyleBackColor = true;
            this.btnFindById.Click += new System.EventHandler(this.btnFindById_Click);
            // 
            // txtFindById
            // 
            this.txtFindById.Location = new System.Drawing.Point(92, 44);
            this.txtFindById.Name = "txtFindById";
            this.txtFindById.Size = new System.Drawing.Size(41, 20);
            this.txtFindById.TabIndex = 1;
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(92, 79);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(127, 20);
            this.txtUpdateName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // grpCreate
            // 
            this.grpCreate.Controls.Add(this.btnCreate);
            this.grpCreate.Controls.Add(this.txtCreateName);
            this.grpCreate.Controls.Add(this.label1);
            this.grpCreate.Location = new System.Drawing.Point(12, 5);
            this.grpCreate.Name = "grpCreate";
            this.grpCreate.Size = new System.Drawing.Size(260, 162);
            this.grpCreate.TabIndex = 4;
            this.grpCreate.TabStop = false;
            this.grpCreate.Text = "Create Category";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(132, 91);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(86, 27);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCreateName
            // 
            this.txtCreateName.Location = new System.Drawing.Point(91, 59);
            this.txtCreateName.Name = "txtCreateName";
            this.txtCreateName.Size = new System.Drawing.Size(127, 20);
            this.txtCreateName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // CategoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 635);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpDelete);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.grpCreate);
            this.Name = "CategoryPage";
            this.Text = "CategoryPage";
            this.Load += new System.EventHandler(this.CategoryPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.grpCreate.ResumeLayout(false);
            this.grpCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnFindById;
        private System.Windows.Forms.TextBox txtFindById;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpCreate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtCreateName;
        private System.Windows.Forms.Label label1;
    }
}