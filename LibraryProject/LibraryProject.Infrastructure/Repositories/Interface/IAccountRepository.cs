using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Infrastructure.Repositories.Interface
{
    public interface IAccountRepository<T>
    {
        bool CheckCredential(string userName, string password);

        T FindByUser(string userName);
    }
}
