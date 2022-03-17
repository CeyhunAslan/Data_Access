using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_CRUD.Repository.Interface
{
    
    interface IKitap<TEntity,TKey> where TEntity : class
    {
        List<TEntity> GettAll();
        bool Save(TEntity entity);
        bool Delete(TEntity entity);
        bool Update(TEntity entity);


    }
}
