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
    public partial class CategoryPage : Form
    {
        public CategoryPage()
        {
            InitializeComponent();
        }
        CategoryRepository categoryRepository = new CategoryRepository();

        private void CategoryPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = categoryRepository.GetByDefaults(x => x.Status != Status.Passive);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Name = txtCreateName.Text;

            categoryRepository.Create(category);

            dataGridView1.DataSource = categoryRepository.GetByDefaults(x => x.Status != Status.Passive);
        }

        private void btnFindById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtFindById.Text);
            Category category = categoryRepository.GetByDefault(x => x.Id == id);

            txtUpdateName.Text = category.Name;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Id = int.Parse(txtFindById.Text);
            category.Name = txtUpdateName.Text;

            categoryRepository.Update(category);

            dataGridView1.DataSource = categoryRepository.GetByDefaults(x => x.Status != Status.Passive);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDelete.Text);
            Category category = categoryRepository.GetByDefault(x => x.Id == id);

            categoryRepository.Delete(category);

            dataGridView1.DataSource = categoryRepository.GetByDefaults(x => x.Status != Status.Passive);
        }
    }
}
