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
    public partial class UserPage : Form
    {
        public UserPage()
        {
            InitializeComponent();
        }

        AppUserRepository appUserRepository = new AppUserRepository();

        private void UserPage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = appUserRepository.GetByDefaults(x => x.Status != Status.Passive);

            cmbCreateRole.Items.AddRange(Enum.GetNames(typeof(Role)));
            cmbCreateRole.SelectedIndex = 0;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            AppUser appUser = new AppUser();
            appUser.FirstName = txtCreateFirstName.Text;
            appUser.LastName = txtCreateLastName.Text;
            appUser.UserName = txtCreateUserName.Text;
            appUser.Password = txtCreatePassword.Text;
            appUser.Role = (Role)Enum.Parse(typeof(Role), cmbCreateRole.Text);

            appUserRepository.Create(appUser);

            dataGridView1.DataSource = appUserRepository.GetByDefaults(x => x.Status != Status.Passive);
        }
    }
}
