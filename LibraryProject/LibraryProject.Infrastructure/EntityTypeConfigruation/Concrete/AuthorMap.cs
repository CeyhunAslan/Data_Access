using LibraryProject.Infrastructure.EntityTypeConfigruation.Abstract;
using LibraryProject.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Infrastructure.EntityTypeConfigruation.Concrete
{
    public class AuthorMap : BaseMap<Author>
    {
        public AuthorMap()
        {
            Property(x => x.FirstName).IsRequired();
            Property(x => x.LastName).IsRequired();
        }
    }
}
