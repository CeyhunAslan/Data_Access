namespace LibraryProject.UI.AdminArea
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoryPage = new System.Windows.Forms.ToolStripMenuItem();
            this.bookPage = new System.Windows.Forms.ToolStripMenuItem();
            this.authorPage = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToAuthors = new System.Windows.Forms.ToolStripMenuItem();
            this.userPage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryPage,
            this.bookPage,
            this.authorPage,
            this.bookToAuthors,
            this.userPage});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categoryPage
            // 
            this.categoryPage.Name = "categoryPage";
            this.categoryPage.Size = new System.Drawing.Size(96, 20);
            this.categoryPage.Text = "Category Page";
            this.categoryPage.Click += new System.EventHandler(this.categoryPage_Click);
            // 
            // bookPage
            // 
            this.bookPage.Name = "bookPage";
            this.bookPage.Size = new System.Drawing.Size(75, 20);
            this.bookPage.Text = "Book Page";
            this.bookPage.Click += new System.EventHandler(this.bookPage_Click);
            // 
            // authorPage
            // 
            this.authorPage.Name = "authorPage";
            this.authorPage.Size = new System.Drawing.Size(85, 20);
            this.authorPage.Text = "Author Page";
            this.authorPage.Click += new System.EventHandler(this.authorPage_Click);
            // 
            // bookToAuthors
            // 
            this.bookToAuthors.Name = "bookToAuthors";
            this.bookToAuthors.Size = new System.Drawing.Size(105, 20);
            this.bookToAuthors.Text = "Book to Authors";
            this.bookToAuthors.Click += new System.EventHandler(this.bookToAuthors_Click);
            // 
            // userPage
            // 
            this.userPage.Name = "userPage";
            this.userPage.Size = new System.Drawing.Size(71, 20);
            this.userPage.Text = "User Page";
            this.userPage.Click += new System.EventHandler(this.userPage_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoryPage;
        private System.Windows.Forms.ToolStripMenuItem bookPage;
        private System.Windows.Forms.ToolStripMenuItem authorPage;
        private System.Windows.Forms.ToolStripMenuItem bookToAuthors;
        private System.Windows.Forms.ToolStripMenuItem userPage;
    }
}