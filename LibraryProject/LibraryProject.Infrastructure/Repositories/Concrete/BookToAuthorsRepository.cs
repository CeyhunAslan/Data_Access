using LibraryProject.Infrastructure.Repositories.Abstract;
using LibraryProject.Infrastructure.Repositories.Interface;
using LibraryProject.Models.Entities.Concrete;
using LibraryProject.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Infrastructure.Repositories.Concrete
{
    public class BookToAuthorsRepository : KernelRepository, IBaseRepository<BookToAuthor>
    {
        public void Create(BookToAuthor item)
        {
            item.Status = Status.Active;
            item.CreateDate = DateTime.Now;

            db.BookToAuthors.Add(item);
            db.SaveChanges();
        }

        public void Delete(BookToAuthor item)
        {
            throw new NotImplementedException();
        }

        public BookToAuthor GetByDefault(Expression<Func<BookToAuthor, bool>> exp)
        {
            return db.BookToAuthors.FirstOrDefault(exp);
        }

     

        public List<BookToAuthor> GetByDefaults(Expression<Func<BookToAuthor, bool>> exp)
        {
            return db.BookToAuthors.Where(exp).ToList();
        }

   

        public void Update(BookToAuthor item)
        {
            throw new NotImplementedException();
        }
    }
}
