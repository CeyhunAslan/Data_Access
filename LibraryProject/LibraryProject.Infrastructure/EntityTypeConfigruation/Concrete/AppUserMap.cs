using LibraryProject.Infrastructure.EntityTypeConfigruation.Abstract;
using LibraryProject.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Infrastructure.EntityTypeConfigruation.Concrete
{
    public class AppUserMap : BaseMap<AppUser>
    {
        public AppUserMap()
        {
            Property(x => x.FirstName).IsRequired();
            Property(x => x.LastName).IsRequired();
            Property(x => x.UserName).IsRequired();
            Property(x => x.Password).IsRequired();
        }
    }
}
