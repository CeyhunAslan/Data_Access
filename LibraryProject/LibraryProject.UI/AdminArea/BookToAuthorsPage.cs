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
    public partial class BookToAuthorsPage : Form
    {
        public BookToAuthorsPage()
        {
            InitializeComponent();
        }
        BookToAuthorsRepository bookToAuthorsRepository = new BookToAuthorsRepository();
        AuthorRepository authorRepository = new AuthorRepository();
        BookRepository bookRepository = new BookRepository();


        private void BookToAuthorsPage_Load(object sender, EventArgs e)
        {
            cmbCreateBook.DataSource = bookRepository.GetByDefaults(x => x.Status != Status.Passive);
            cmbCreateBook.DisplayMember = "Title";
            cmbCreateBook.ValueMember = "Id";
            cmbCreateBook.SelectedIndex = -1;

            cmbCreateAuthor.DataSource = authorRepository.GetByDefaults(x => x.Status != Status.Passive);
            cmbCreateAuthor.DisplayMember = "FullName";
            cmbCreateAuthor.ValueMember = "Id";
            cmbCreateAuthor.SelectedIndex = -1;

            dataGridView1.DataSource = bookToAuthorsRepository.GetByDefaults(x => x.Status != Status.Passive);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            BookToAuthor assignedBookToAuthor = new BookToAuthor();

            assignedBookToAuthor.BookId = (int)cmbCreateBook.SelectedValue;
            assignedBookToAuthor.AuthorId = (int)cmbCreateAuthor.SelectedValue;

            bookToAuthorsRepository.Create(assignedBookToAuthor);

            dataGridView1.DataSource = bookToAuthorsRepository.GetByDefaults(x => x.Status != Status.Passive);
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDetail.Text);

            var item = bookToAuthorsRepository.GetByDefault(x => x.BookId == id);

            MessageBox.Show(
                $"Book Title: {item.Book.Title}\nAuthor Name: {item.Author.FullName}\nCategory Name: {item.Book.Category.Name}");
        }
    }
}
