using LibraryProject.Models.Entities.Abstract;
using LibraryProject.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Models.Entities.Concrete
{
    public class AppUser : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //[NotMapped] => Bu attribute sayesinde FullName sütunu veri tabanında oluşmayacak
        //public string FullName { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        public Role Role { get; set; }
    }
}
