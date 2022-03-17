using LibraryProject.Infrastructure.EntityTypeConfigruation.Abstract;
using LibraryProject.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Infrastructure.EntityTypeConfigruation.Concrete
{
    public class BookToAuthorMap : BaseMap<BookToAuthor>
    {
        public BookToAuthorMap()
        {
            HasRequired(x => x.Book)
                .WithMany(x => x.BookToAuthors)
                .HasForeignKey(x => x.BookId)
                .WillCascadeOnDelete(false);

            HasRequired(x => x.Author)
                .WithMany(x => x.BookToAuthors)
                .HasForeignKey(x => x.AuthorId)
                .WillCascadeOnDelete(false);
        }
    }
}
