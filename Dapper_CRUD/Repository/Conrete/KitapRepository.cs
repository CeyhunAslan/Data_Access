using Dapper;
using Dapper_CRUD.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_CRUD.Repository.Conrete
{
   
    public class KitapRepository : IKitap<Kitap, int>
    {
        SqlConnection DbConnection = new SqlConnection(@"Data Source=SHADOWBLOOD\ETA;Initial Catalog=DapperExample; Integrated Security=True;");
        public bool Delete(Kitap entity)
        {
            try
            {
                sqlOpen();

                DbConnection.Query<Kitap>(@"Delete From [dbo].[Kitap] Where Id = @Id", entity);

                return true;

            }
            catch (Exception ex)
            {

                throw new Exception("Delete Business hatası " + ex.Message.ToString());
            }
            finally
            {
                sqlClose();
            }
        }

     

        public List<Kitap> GettAll()
        {
            try
            {
                sqlOpen();

                List<Kitap> kitaps = DbConnection.Query<Kitap>("Select * from [dbo].[Kitap]").ToList();
                return kitaps;
            }
            catch (Exception ex)
            {

                throw new Exception("List Business hatası " + ex.Message.ToString());
            }
            finally 
            {
                sqlClose();
            }
        }

        public bool Save(Kitap entity)
        {
            try
            {
                sqlOpen();

                DbConnection.Query<Kitap>("Insert Into [dbo].[Kitap] ([Name] , [SeriesName] , [Author ]) Values (@Name , @SeriesName , @Author)",entity);

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Save Business hatası " + ex.Message.ToString());
            }
            finally 
            {
                sqlClose(); 
            }
        }

        public bool Update(Kitap entity)
        {
            try
            {
                sqlOpen();

                DbConnection.Query<Kitap>(@"Update [dbo].[Kitap] Set [Name] = @Name ,
                                                                     [SeriesName] = @Series
                                                                     [Author] = @Author",entity);

                return true;
            }
            catch (Exception ex)
            {

                throw new Exception("Update Business hatası " + ex.Message.ToString());
            }
            finally 
            { 
                sqlClose(); 
            } 
        }
        #region Connection Open Close Method
        public void sqlOpen()
        {
            if (DbConnection.State == System.Data.ConnectionState.Closed)
            {
                DbConnection.Open();
            }
        }

        private void sqlClose()
        {
            if (DbConnection.State == System.Data.ConnectionState.Open)
            {
                DbConnection.Close();
            }
        } 
        #endregion
    }
}
