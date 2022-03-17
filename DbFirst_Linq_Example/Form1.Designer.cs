namespace DbFirst_Linq_Example
{
    partial class Form1
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
            this.btnExample_1 = new System.Windows.Forms.Button();
            this.btnExample_2 = new System.Windows.Forms.Button();
            this.btnExample_3 = new System.Windows.Forms.Button();
            this.btnExample_4 = new System.Windows.Forms.Button();
            this.btnExample_5 = new System.Windows.Forms.Button();
            this.btnExample_6 = new System.Windows.Forms.Button();
            this.btnExample_7 = new System.Windows.Forms.Button();
            this.btnExample_8 = new System.Windows.Forms.Button();
            this.btnExample_9 = new System.Windows.Forms.Button();
            this.btnExample_10 = new System.Windows.Forms.Button();
            this.btnExample_11 = new System.Windows.Forms.Button();
            this.btnExample_12 = new System.Windows.Forms.Button();
            this.btnExample_13 = new System.Windows.Forms.Button();
            this.btnExample_14 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExample_15 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExample_1
            // 
            this.btnExample_1.Location = new System.Drawing.Point(12, 286);
            this.btnExample_1.Name = "btnExample_1";
            this.btnExample_1.Size = new System.Drawing.Size(206, 53);
            this.btnExample_1.TabIndex = 3;
            this.btnExample_1.Text = "ToList()";
            this.btnExample_1.UseVisualStyleBackColor = true;
            this.btnExample_1.Click += new System.EventHandler(this.btnExample_1_Click);
            // 
            // btnExample_2
            // 
            this.btnExample_2.Location = new System.Drawing.Point(224, 286);
            this.btnExample_2.Name = "btnExample_2";
            this.btnExample_2.Size = new System.Drawing.Size(206, 53);
            this.btnExample_2.TabIndex = 4;
            this.btnExample_2.Text = "Select()";
            this.btnExample_2.UseVisualStyleBackColor = true;
            this.btnExample_2.Click += new System.EventHandler(this.btnExample_2_Click);
            // 
            // btnExample_3
            // 
            this.btnExample_3.Location = new System.Drawing.Point(436, 286);
            this.btnExample_3.Name = "btnExample_3";
            this.btnExample_3.Size = new System.Drawing.Size(206, 53);
            this.btnExample_3.TabIndex = 5;
            this.btnExample_3.Text = "Where()";
            this.btnExample_3.UseVisualStyleBackColor = true;
            this.btnExample_3.Click += new System.EventHandler(this.btnExample_3_Click);
            // 
            // btnExample_4
            // 
            this.btnExample_4.Location = new System.Drawing.Point(648, 286);
            this.btnExample_4.Name = "btnExample_4";
            this.btnExample_4.Size = new System.Drawing.Size(206, 53);
            this.btnExample_4.TabIndex = 6;
            this.btnExample_4.Text = "First()";
            this.btnExample_4.UseVisualStyleBackColor = true;
            this.btnExample_4.Click += new System.EventHandler(this.btnExample_4_Click);
            // 
            // btnExample_5
            // 
            this.btnExample_5.Location = new System.Drawing.Point(860, 286);
            this.btnExample_5.Name = "btnExample_5";
            this.btnExample_5.Size = new System.Drawing.Size(206, 53);
            this.btnExample_5.TabIndex = 7;
            this.btnExample_5.Text = "FirstorDefault()";
            this.btnExample_5.UseVisualStyleBackColor = true;
            this.btnExample_5.Click += new System.EventHandler(this.btnExample_5_Click);
            // 
            // btnExample_6
            // 
            this.btnExample_6.Location = new System.Drawing.Point(12, 345);
            this.btnExample_6.Name = "btnExample_6";
            this.btnExample_6.Size = new System.Drawing.Size(206, 53);
            this.btnExample_6.TabIndex = 8;
            this.btnExample_6.Text = "Find()";
            this.btnExample_6.UseVisualStyleBackColor = true;
            this.btnExample_6.Click += new System.EventHandler(this.btnExample_6_Click);
            // 
            // btnExample_7
            // 
            this.btnExample_7.Location = new System.Drawing.Point(224, 345);
            this.btnExample_7.Name = "btnExample_7";
            this.btnExample_7.Size = new System.Drawing.Size(206, 53);
            this.btnExample_7.TabIndex = 9;
            this.btnExample_7.Text = "Take()";
            this.btnExample_7.UseVisualStyleBackColor = true;
            this.btnExample_7.Click += new System.EventHandler(this.btnExample_7_Click);
            // 
            // btnExample_8
            // 
            this.btnExample_8.Location = new System.Drawing.Point(436, 345);
            this.btnExample_8.Name = "btnExample_8";
            this.btnExample_8.Size = new System.Drawing.Size(206, 53);
            this.btnExample_8.TabIndex = 10;
            this.btnExample_8.Text = "Skip()";
            this.btnExample_8.UseVisualStyleBackColor = true;
            this.btnExample_8.Click += new System.EventHandler(this.btnExample_8_Click);
            // 
            // btnExample_9
            // 
            this.btnExample_9.Location = new System.Drawing.Point(648, 345);
            this.btnExample_9.Name = "btnExample_9";
            this.btnExample_9.Size = new System.Drawing.Size(206, 53);
            this.btnExample_9.TabIndex = 11;
            this.btnExample_9.Text = "Contains()";
            this.btnExample_9.UseVisualStyleBackColor = true;
            this.btnExample_9.Click += new System.EventHandler(this.btnExample_9_Click);
            // 
            // btnExample_10
            // 
            this.btnExample_10.Location = new System.Drawing.Point(860, 345);
            this.btnExample_10.Name = "btnExample_10";
            this.btnExample_10.Size = new System.Drawing.Size(206, 53);
            this.btnExample_10.TabIndex = 12;
            this.btnExample_10.Text = "StartWith()";
            this.btnExample_10.UseVisualStyleBackColor = true;
            this.btnExample_10.Click += new System.EventHandler(this.btnExample_10_Click);
            // 
            // btnExample_11
            // 
            this.btnExample_11.Location = new System.Drawing.Point(12, 404);
            this.btnExample_11.Name = "btnExample_11";
            this.btnExample_11.Size = new System.Drawing.Size(206, 53);
            this.btnExample_11.TabIndex = 13;
            this.btnExample_11.Text = "EndWith()";
            this.btnExample_11.UseVisualStyleBackColor = true;
            this.btnExample_11.Click += new System.EventHandler(this.btnExample_11_Click);
            // 
            // btnExample_12
            // 
            this.btnExample_12.Location = new System.Drawing.Point(224, 404);
            this.btnExample_12.Name = "btnExample_12";
            this.btnExample_12.Size = new System.Drawing.Size(206, 53);
            this.btnExample_12.TabIndex = 14;
            this.btnExample_12.Text = "Any()";
            this.btnExample_12.UseVisualStyleBackColor = true;
            this.btnExample_12.Click += new System.EventHandler(this.btnExample_12_Click);
            // 
            // btnExample_13
            // 
            this.btnExample_13.Location = new System.Drawing.Point(436, 404);
            this.btnExample_13.Name = "btnExample_13";
            this.btnExample_13.Size = new System.Drawing.Size(206, 53);
            this.btnExample_13.TabIndex = 15;
            this.btnExample_13.Text = "Count()";
            this.btnExample_13.UseVisualStyleBackColor = true;
            this.btnExample_13.Click += new System.EventHandler(this.btnExample_13_Click);
            // 
            // btnExample_14
            // 
            this.btnExample_14.Location = new System.Drawing.Point(648, 404);
            this.btnExample_14.Name = "btnExample_14";
            this.btnExample_14.Size = new System.Drawing.Size(206, 53);
            this.btnExample_14.TabIndex = 16;
            this.btnExample_14.Text = "Sum()";
            this.btnExample_14.UseVisualStyleBackColor = true;
            this.btnExample_14.Click += new System.EventHandler(this.btnExample_14_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1054, 268);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnExample_15
            // 
            this.btnExample_15.Location = new System.Drawing.Point(860, 404);
            this.btnExample_15.Name = "btnExample_15";
            this.btnExample_15.Size = new System.Drawing.Size(206, 53);
            this.btnExample_15.TabIndex = 17;
            this.btnExample_15.Text = "Max()";
            this.btnExample_15.UseVisualStyleBackColor = true;
            this.btnExample_15.Click += new System.EventHandler(this.btnExample_15_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(860, 542);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 53);
            this.button2.TabIndex = 17;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 626);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExample_15);
            this.Controls.Add(this.btnExample_1);
            this.Controls.Add(this.btnExample_2);
            this.Controls.Add(this.btnExample_3);
            this.Controls.Add(this.btnExample_4);
            this.Controls.Add(this.btnExample_5);
            this.Controls.Add(this.btnExample_6);
            this.Controls.Add(this.btnExample_7);
            this.Controls.Add(this.btnExample_8);
            this.Controls.Add(this.btnExample_9);
            this.Controls.Add(this.btnExample_10);
            this.Controls.Add(this.btnExample_11);
            this.Controls.Add(this.btnExample_12);
            this.Controls.Add(this.btnExample_13);
            this.Controls.Add(this.btnExample_14);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Db First and Linq  Example";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExample_1;
        private System.Windows.Forms.Button btnExample_2;
        private System.Windows.Forms.Button btnExample_3;
        private System.Windows.Forms.Button btnExample_4;
        private System.Windows.Forms.Button btnExample_5;
        private System.Windows.Forms.Button btnExample_6;
        private System.Windows.Forms.Button btnExample_7;
        private System.Windows.Forms.Button btnExample_8;
        private System.Windows.Forms.Button btnExample_9;
        private System.Windows.Forms.Button btnExample_10;
        private System.Windows.Forms.Button btnExample_11;
        private System.Windows.Forms.Button btnExample_12;
        private System.Windows.Forms.Button btnExample_13;
        private System.Windows.Forms.Button btnExample_14;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExample_15;
        private System.Windows.Forms.Button button2;
    }
}

