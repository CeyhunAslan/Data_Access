using LibraryProject.Infrastructure.EntityTypeConfigruation.Abstract;
using LibraryProject.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Infrastructure.EntityTypeConfigruation.Concrete
{
    public class BookMap : BaseMap<Book>
    {
        public BookMap()
        {
            Property(x => x.Title).IsRequired();
            Property(x => x.Description).IsOptional();
            Property(x => x.Pricture).IsRequired();

            //Book İle Category arasındaki ilişkiyi tanımladık.
            HasRequired(x => x.Category)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.CategoryId)
                .WillCascadeOnDelete(false);
        }
    }
}
