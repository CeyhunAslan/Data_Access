using LibraryProject.Infrastructure.Repositories.Concrete;
using LibraryProject.Models.Entities.Concrete;
using LibraryProject.Models.Enums;
using LibraryProject.UI.AdminArea;
using LibraryProject.UI.MemberArea;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.UI
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        AppUserRepository appUserRepository = new AppUserRepository();
        private void btnSignIn_Click(object sender, EventArgs e)
        {

                //Kullanıcıdan alınan bilgilere göre böyle bir user var mı yok mu diye veri tabanından baktık. Varsa true dönecek yoksa false dönecek
                bool result = appUserRepository.CheckCredential(txtUserName.Text, txtPassword.Text);

                if (result) //şayet result true ise 
                {
                    //Yukarıda varlığını kontrol ettiğimiz kullanıcının bilgilerini getirdik. 
                    AppUser appUser = appUserRepository.FindByUser(txtUserName.Text);

                    //Eğer bir üst adımda yakaladığım kullanıcının Rolü Admin ise AdminHome değilde Rolüne göre diğer Home sayfalarına yönlendirdik
                    if (appUser.Role == Role.Admin)
                    {
                        Home home = new Home();
                        home.Show();
                    }
                    else if (appUser.Role == Role.Member)
                    {
                        MemberHome home = new MemberHome();
                        home.Show();
                    }
                }
            
        }
    }
}
