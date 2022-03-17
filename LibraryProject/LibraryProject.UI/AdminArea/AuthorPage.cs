using LibraryProject.Infrastructure.Repositories.Concrete;
using LibraryProject.Models.Entities.Concrete;
using LibraryProject.Models.Enums;
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
    public partial class AuthorPage : Form
    {
        public AuthorPage()
        {
            InitializeComponent();
        }
        AuthorRepository authorRepository = new AuthorRepository();
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Author author = new Author();

            author.FirstName = txtCreateFirstName.Text;
            author.LastName = txtCreateLastName.Text;

            authorRepository.Create(author);

            dataGridView1.DataSource = authorRepository.GetByDefaults(x => x.Status != Status.Passive);
        }

        private void AuthorPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = authorRepository.GetByDefaults(x => x.Status != Status.Passive);
        }
    }
}
