using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.UI.AdminArea
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        void ChildForm(Form _childForm)
        {
            this.Width = _childForm.Width;
            this.Height = _childForm.Height;

            bool condition = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    condition = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }
            }

            if (condition == false)
            {
                _childForm.MdiParent = this;
                _childForm.Show();
            }
        }
        private void categoryPage_Click(object sender, EventArgs e)
        {
            ChildForm(new CategoryPage());
        }

        private void bookPage_Click(object sender, EventArgs e)
        {
            ChildForm(new BookPage());
        }

        private void authorPage_Click(object sender, EventArgs e)
        {
            ChildForm(new AuthorPage());
        }

        private void bookToAuthors_Click(object sender, EventArgs e)
        {
            ChildForm(new BookToAuthorsPage());
        }

        private void userPage_Click(object sender, EventArgs e)
        {
            ChildForm(new UserPage());
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
