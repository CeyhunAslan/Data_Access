using LibraryProject.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Models.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
