namespace LibraryProject.UI.AdminArea
{
    partial class BookPage
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
            this.grpGetByCreateDate = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGetByDate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.cmbUpdate = new System.Windows.Forms.ComboBox();
            this.txtUpdateDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFindById = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdateTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpCreate = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cmbCreate = new System.Windows.Forms.ComboBox();
            this.txtCreateDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCreateTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpGetByCreateDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpUpdate.SuspendLayout();
            this.grpCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGetByCreateDate
            // 
            this.grpGetByCreateDate.Controls.Add(this.label9);
            this.grpGetByCreateDate.Controls.Add(this.btnGetByDate);
            this.grpGetByCreateDate.Controls.Add(this.label8);
            this.grpGetByCreateDate.Controls.Add(this.dtpEnd);
            this.grpGetByCreateDate.Controls.Add(this.dtpStart);
            this.grpGetByCreateDate.Location = new System.Drawing.Point(452, 12);
            this.grpGetByCreateDate.Name = "grpGetByCreateDate";
            this.grpGetByCreateDate.Size = new System.Drawing.Size(317, 189);
            this.grpGetByCreateDate.TabIndex = 14;
            this.grpGetByCreateDate.TabStop = false;
            this.grpGetByCreateDate.Text = "Get Books";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "End Date:";
            // 
            // btnGetByDate
            // 
            this.btnGetByDate.Location = new System.Drawing.Point(192, 143);
            this.btnGetByDate.Name = "btnGetByDate";
            this.btnGetByDate.Size = new System.Drawing.Size(97, 40);
            this.btnGetByDate.TabIndex = 3;
            this.btnGetByDate.Text = "Submit";
            this.btnGetByDate.UseVisualStyleBackColor = true;
            this.btnGetByDate.Click += new System.EventHandler(this.btnGetByDate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Start Date:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(13, 111);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(276, 20);
            this.dtpEnd.TabIndex = 6;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(13, 52);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(276, 20);
            this.dtpStart.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 403);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 197);
            this.dataGridView1.TabIndex = 13;
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.btnUpdate);
            this.grpUpdate.Controls.Add(this.btnFind);
            this.grpUpdate.Controls.Add(this.cmbUpdate);
            this.grpUpdate.Controls.Add(this.txtUpdateDescription);
            this.grpUpdate.Controls.Add(this.label2);
            this.grpUpdate.Controls.Add(this.label3);
            this.grpUpdate.Controls.Add(this.txtFindById);
            this.grpUpdate.Controls.Add(this.label7);
            this.grpUpdate.Controls.Add(this.txtUpdateTitle);
            this.grpUpdate.Controls.Add(this.label4);
            this.grpUpdate.Location = new System.Drawing.Point(232, 12);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(214, 375);
            this.grpUpdate.TabIndex = 11;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Update Book";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(93, 267);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 32);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(93, 53);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(97, 28);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cmbUpdate
            // 
            this.cmbUpdate.FormattingEnabled = true;
            this.cmbUpdate.Location = new System.Drawing.Point(28, 226);
            this.cmbUpdate.Name = "cmbUpdate";
            this.cmbUpdate.Size = new System.Drawing.Size(162, 21);
            this.cmbUpdate.TabIndex = 2;
            // 
            // txtUpdateDescription
            // 
            this.txtUpdateDescription.Location = new System.Drawing.Point(28, 168);
            this.txtUpdateDescription.Name = "txtUpdateDescription";
            this.txtUpdateDescription.Size = new System.Drawing.Size(162, 20);
            this.txtUpdateDescription.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose a Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description:";
            // 
            // txtFindById
            // 
            this.txtFindById.Location = new System.Drawing.Point(28, 55);
            this.txtFindById.Name = "txtFindById";
            this.txtFindById.Size = new System.Drawing.Size(59, 20);
            this.txtFindById.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Id:";
            // 
            // txtUpdateTitle
            // 
            this.txtUpdateTitle.Location = new System.Drawing.Point(28, 107);
            this.txtUpdateTitle.Name = "txtUpdateTitle";
            this.txtUpdateTitle.Size = new System.Drawing.Size(162, 20);
            this.txtUpdateTitle.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Title:";
            // 
            // grpCreate
            // 
            this.grpCreate.Controls.Add(this.btnCreate);
            this.grpCreate.Controls.Add(this.cmbCreate);
            this.grpCreate.Controls.Add(this.txtCreateDescription);
            this.grpCreate.Controls.Add(this.label6);
            this.grpCreate.Controls.Add(this.label5);
            this.grpCreate.Controls.Add(this.txtCreateTitle);
            this.grpCreate.Controls.Add(this.label1);
            this.grpCreate.Location = new System.Drawing.Point(12, 12);
            this.grpCreate.Name = "grpCreate";
            this.grpCreate.Size = new System.Drawing.Size(214, 375);
            this.grpCreate.TabIndex = 12;
            this.grpCreate.TabStop = false;
            this.grpCreate.Text = "Create Book";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(95, 226);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(97, 30);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cmbCreate
            // 
            this.cmbCreate.FormattingEnabled = true;
            this.cmbCreate.Location = new System.Drawing.Point(30, 184);
            this.cmbCreate.Name = "cmbCreate";
            this.cmbCreate.Size = new System.Drawing.Size(162, 21);
            this.cmbCreate.TabIndex = 2;
            // 
            // txtCreateDescription
            // 
            this.txtCreateDescription.Location = new System.Drawing.Point(30, 126);
            this.txtCreateDescription.Name = "txtCreateDescription";
            this.txtCreateDescription.Size = new System.Drawing.Size(162, 20);
            this.txtCreateDescription.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Choose a Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Description:";
            // 
            // txtCreateTitle
            // 
            this.txtCreateTitle.Location = new System.Drawing.Point(30, 65);
            this.txtCreateTitle.Name = "txtCreateTitle";
            this.txtCreateTitle.Size = new System.Drawing.Size(162, 20);
            this.txtCreateTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // BookPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 637);
            this.Controls.Add(this.grpGetByCreateDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.grpCreate);
            this.Name = "BookPage";
            this.Text = "BookPage";
            this.Load += new System.EventHandler(this.BookPage_Load);
            this.grpGetByCreateDate.ResumeLayout(false);
            this.grpGetByCreateDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.grpCreate.ResumeLayout(false);
            this.grpCreate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGetByCreateDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGetByDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cmbUpdate;
        private System.Windows.Forms.TextBox txtUpdateDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFindById;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpdateTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpCreate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cmbCreate;
        private System.Windows.Forms.TextBox txtCreateDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCreateTitle;
        private System.Windows.Forms.Label label1;
    }
}