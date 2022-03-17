using LibraryProject.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Models.Entities.Concrete
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Pricture { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual List<BookToAuthor> BookToAuthors { get; set; }
    }
}
