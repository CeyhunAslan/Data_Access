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
    public partial class BookPage : Form
    {
        public BookPage()
        {
            InitializeComponent();
        }
        CategoryRepository categoryRepository = new CategoryRepository();
        BookRepository bookRepository = new BookRepository();
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = txtCreateTitle.Text;
            book.Description = txtCreateDescription.Text;
            book.CategoryId = (int)cmbCreate.SelectedValue;
            bookRepository.Create(book);

            dataGridView1.DataSource = bookRepository.GetByDefaults(x => x.Status != Status.Passive);
        }
        public static int id;
        private void BookPage_Load(object sender, EventArgs e)
        {
            cmbCreate.DataSource = categoryRepository.GetByDefaults(x => x.Status != Status.Passive);
            cmbCreate.DisplayMember = "Name";
            cmbCreate.ValueMember = "Id";
            cmbCreate.SelectedIndex = -1;


            cmbUpdate.DataSource = categoryRepository.GetByDefaults(x => x.Status != Status.Passive);
            cmbUpdate.DisplayMember = "Name";
            cmbUpdate.ValueMember = "Id";
            cmbUpdate.SelectedIndex = -1;

            dataGridView1.DataSource = bookRepository.GetByDefaults(x => x.Status != Status.Passive);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtFindById.Text);

            Book book = bookRepository.GetByDefault(x => x.Id == id);

            txtUpdateTitle.Text = book.Title;
            txtUpdateDescription.Text = book.Description;
       

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Book book = new Book();

            book.Id = int.Parse(txtFindById.Text);
            book.Title = txtUpdateTitle.Text;
            book.Description = txtUpdateDescription.Text;
            book.CategoryId = (int)cmbUpdate.SelectedValue;
            bookRepository.Update(book);

            dataGridView1.DataSource = bookRepository.GetByDefaults(x => x.Status != Status.Passive);
        }

      

        private void btnGetByDate_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bookRepository.GetByDefaults(x => x.CreateDate >= dtpStart.Value && x.CreateDate <= dtpEnd.Value);
        }
    }
}
