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
    public class BookRepository : KernelRepository, IBaseRepository<Book>
    {
        public void Create(Book item)
        {
            item.Status = Status.Active;
            item.CreateDate = DateTime.Now;
            db.Books.Add(item);
            db.SaveChanges();
        }

        public void Delete(Book item)
        {
            item.Status = Status.Passive;
            item.DeleteDate = DateTime.Now;
            db.SaveChanges();
        }

        public Book GetByDefault(Expression<Func<Book, bool>> exp)
        {
            return db.Books.FirstOrDefault(exp);
        }

        public List<Book> GetByDefaults(Expression<Func<Book, bool>> exp)
        {
            return db.Books.Where(exp).ToList();
        }

        public void Update(Book item)
        {
            Book book = GetByDefault(x => x.Id == item.Id);

            book.Status = Status.Modified;
            book.UpdateDate = DateTime.Now;
            book.Title = item.Title;
            book.Description = item.Description;
            book.CategoryId = item.CategoryId;
            book.Pricture = item.Pricture;
            db.SaveChanges();
        }
    }
}
