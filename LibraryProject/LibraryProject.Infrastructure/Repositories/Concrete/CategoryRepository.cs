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
    public class CategoryRepository : KernelRepository, IBaseRepository<Category>
    {
        public void Create(Category item)
        {
            item.Status = Status.Active;
            item.CreateDate = DateTime.Now;
            db.Categories.Add(item);
            db.SaveChanges();
        }

        public void Delete(Category item)
        {
            item.Status = Status.Passive;
            item.DeleteDate = DateTime.Now;
            db.SaveChanges();
        }

        public Category GetByDefault(Expression<Func<Category, bool>> exp)
        {
            return db.Categories.FirstOrDefault(exp);
            //ui'da bu fonksiyon çağrıldığında aşağıdaki gibi kullanılacak
            //categoryRepository.GetByDefault(x=> x.Status != Status.Passive)
            //categoryRepository.GetByDefault(x=> x.Name.Constains("a"))
            //categoryRepository.GetByDefault(x=> x.Id == id)
            //categoryRepository.GetByDefault(x=> x.Status == Status.Moddified && x.Id == 5)
        }



        public List<Category> GetByDefaults(Expression<Func<Category, bool>> exp)
        {
            return db.Categories.Where(exp).ToList();
        }


        public void Update(Category item)
        {
            Category category = GetByDefault(x => x.Id == item.Id);

            category.Status = Status.Modified;
            category.UpdateDate = DateTime.Now;
            category.Name = item.Name;
            db.SaveChanges();
        }
    }
}
