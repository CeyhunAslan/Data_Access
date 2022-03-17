using LibraryProject.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Models.Entities.Concrete
{
    public class Author : BaseEntity
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => FirstName + ' ' + LastName;

        public virtual List<BookToAuthor> BookToAuthors { get; set; }
    }
}
