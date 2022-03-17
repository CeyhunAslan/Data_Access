namespace LibraryProject.UI.AdminArea
{
    partial class BookToAuthorsPage
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
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.btnDetail = new System.Windows.Forms.Button();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpCreate = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cmbCreateAuthor = new System.Windows.Forms.ComboBox();
            this.cmbCreateBook = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.btnDetail);
            this.grpDetail.Controls.Add(this.txtDetail);
            this.grpDetail.Controls.Add(this.label3);
            this.grpDetail.Location = new System.Drawing.Point(260, 12);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(213, 88);
            this.grpDetail.TabIndex = 5;
            this.grpDetail.TabStop = false;
            this.grpDetail.Text = "Detail";
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(114, 34);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(75, 26);
            this.btnDetail.TabIndex = 4;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(52, 34);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(56, 20);
            this.txtDetail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 258);
            this.dataGridView1.TabIndex = 4;
            // 
            // grpCreate
            // 
            this.grpCreate.Controls.Add(this.btnCreate);
            this.grpCreate.Controls.Add(this.cmbCreateAuthor);
            this.grpCreate.Controls.Add(this.cmbCreateBook);
            this.grpCreate.Controls.Add(this.label2);
            this.grpCreate.Controls.Add(this.label1);
            this.grpCreate.Location = new System.Drawing.Point(12, 12);
            this.grpCreate.Name = "grpCreate";
            this.grpCreate.Size = new System.Drawing.Size(242, 218);
            this.grpCreate.TabIndex = 3;
            this.grpCreate.TabStop = false;
            this.grpCreate.Text = "Create";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(123, 153);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(91, 36);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cmbCreateAuthor
            // 
            this.cmbCreateAuthor.FormattingEnabled = true;
            this.cmbCreateAuthor.Location = new System.Drawing.Point(28, 119);
            this.cmbCreateAuthor.Name = "cmbCreateAuthor";
            this.cmbCreateAuthor.Size = new System.Drawing.Size(186, 21);
            this.cmbCreateAuthor.TabIndex = 1;
            // 
            // cmbCreateBook
            // 
            this.cmbCreateBook.FormattingEnabled = true;
            this.cmbCreateBook.Location = new System.Drawing.Point(28, 60);
            this.cmbCreateBook.Name = "cmbCreateBook";
            this.cmbCreateBook.Size = new System.Drawing.Size(186, 21);
            this.cmbCreateBook.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose Author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Book:";
            // 
            // BookToAuthorsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 535);
            this.Controls.Add(this.grpDetail);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpCreate);
            this.Name = "BookToAuthorsPage";
            this.Text = "BookToAuthorsPage";
            this.Load += new System.EventHandler(this.BookToAuthorsPage_Load);
            this.grpDetail.ResumeLayout(false);
            this.grpDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpCreate.ResumeLayout(false);
            this.grpCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpCreate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cmbCreateAuthor;
        private System.Windows.Forms.ComboBox cmbCreateBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}