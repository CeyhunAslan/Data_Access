using LibraryProject.Infrastructure.EntityTypeConfigruation.Abstract;
using LibraryProject.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Infrastructure.EntityTypeConfigruation.Concrete
{
    public class CategoryMap : BaseMap<Category>
    {
        public CategoryMap()
        {
            ToTable("dbo.Categories");//Bu işlemi burada yapmaya gerek yoktur. Çünkü AppDbContext sınıfında zaten model'deki sınıfları DBSet ederken isim veriyoruz.
            Property(x => x.Name).HasMaxLength(50).IsRequired(); //Burada HasMaxLengt vermeseydik EF bu property veri tabanına nvarchar dönüştürerek max basacaktı.
        }
    }
}
