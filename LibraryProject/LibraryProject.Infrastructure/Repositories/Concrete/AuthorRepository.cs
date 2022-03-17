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
    public class AuthorRepository : KernelRepository, IBaseRepository<Author>
    {
        public void Create(Author item)
        {
            item.Status = Status.Active;
            item.CreateDate = DateTime.Now;
            db.Authors.Add(item);
            db.SaveChanges();
        }

        public void Delete(Author item)
        {
            item.Status = Status.Passive;
            item.DeleteDate = DateTime.Now;
            db.SaveChanges();
        }

        public Author GetByDefault(Expression<Func<Author, bool>> exp)
        {
            return db.Authors.FirstOrDefault(exp);
        }

        public List<Author> GetByDefaults(Expression<Func<Author, bool>> exp)
        {
            return db.Authors.Where(exp).ToList();
        }

        public void Update(Author item)
        {
            Author author = GetByDefault(x => x.Id == item.Id);

            author.Status = Status.Modified;
            author.UpdateDate = DateTime.Now;
            author.FirstName = item.FirstName;
            author.LastName = item.LastName;

            db.SaveChanges();
        }
    }
}
