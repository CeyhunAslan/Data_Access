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
    public class AppUserRepository : KernelRepository,
                                        IBaseRepository<AppUser>,
                                        IAccountRepository<AppUser>
    {
        public bool CheckCredential(string userName, string password)
        {
            return db.AppUsers.Any(x => x.UserName == userName && x.Password == password);
        }

        public void Create(AppUser item)
        {
            item.Status = Status.Active;
            item.CreateDate = DateTime.Now;
            db.AppUsers.Add(item);
            db.SaveChanges();
        }

        public void Delete(AppUser item)
        {
            item.Status = Status.Passive;
            item.DeleteDate = DateTime.Now;
            db.SaveChanges();
        }

        public AppUser FindByUser(string userName)
        {
            return db.AppUsers.FirstOrDefault(x => x.UserName == userName);
        }

        public AppUser GetByDefault(Expression<Func<AppUser, bool>> exp)
        {
            return db.AppUsers.FirstOrDefault(exp);
        }

    

        public List<AppUser> GetByDefaults(Expression<Func<AppUser, bool>> exp)
        {
            return db.AppUsers.Where(exp).ToList();
        }

        public void Update(AppUser item)
        {
            AppUser appUser = GetByDefault(x => x.Id == item.Id);

            appUser.Status = Status.Modified;
            appUser.UpdateDate = DateTime.Now;
            appUser.FirstName = item.FirstName;
            appUser.LastName = item.LastName;
            appUser.Role = item.Role;
            appUser.Password = item.Password;
            appUser.UserName = item.UserName;
            db.SaveChanges();
        }
    }
}
