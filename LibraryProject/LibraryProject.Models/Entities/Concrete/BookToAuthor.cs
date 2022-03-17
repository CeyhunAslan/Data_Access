using LibraryProject.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Models.Entities.Concrete
{
    public class BookToAuthor : BaseEntity
    {
        public int BookId { get; set; }
        public virtual Book Book { get; set; }

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
