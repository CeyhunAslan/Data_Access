using LibraryProject.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Infrastructure.EntityTypeConfigruation.Abstract
{
    //Fluent Apı yapıyourz. Profesyonel olarak burda entity'lerimizin annotasyonunu yapıyoruz.
    //EntityTypeConfiguration<T> where T: BaseEntity bu yapıyı ilk kez gördünüz. Burada where T: BaseEntity diyerek bu sınıf içerisinde T'nin BaseEntity olmasını temin ettik. Aşağıda constructor methodu incelerseniz sadece BaseEntity.cs sınıfının propery'lerinin geldiğini göreceksiniz.
    //Ayrıca BaseMap içinde T type geçtik çünkü her bir alt sınıfta farklı bir entity tip olarak verip onunun configurasyonunu yapacağım. Ayrıca bu yapıyı kurarak yönetim kolaylığı ve kod kalabalığını engelledik. BU yapıyı kuramsaydık BaseEntity'nin her bir özelliğini, CategoryMap, BookMap sınıflarında tekrar tekrar yapamının önüne geçtik
    public abstract class BaseMap<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseMap()
        {
            //EF bizim için bu configurasyonları zaten yapıyordu. Örneğin Id özelliğini "Identity" işaretlemeseydim EF zaten benim için yapacaktı. "CreateDate" property'sinin adı zaten CreateDate ve zaten EF tipin datatime2 olarak ve Required olarak veri tabanında yaratacaktı.
            //Peki biz bu configurasyonalrı neden yaptık?
            //1. Öğrenmek ve bilmek için.
            //2. Bir özelliğe müdahele etmek istediğimizde. Örneğin "UpdateDate" property'sine biz aşağıda "IsOptional()" yani boş geçilebilir demeseydik EF onu default olarak Required yapacaktı. Yada bir property'nin adını tipini değiştirmek istediğmizde bu configurasyon yapısnı bu mimari yaklaşımı ile yapacağız.
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CreateDate).HasColumnName("CreateDate").HasColumnType("datetime2").IsRequired();
            Property(x => x.UpdateDate).HasColumnName("UpdateDate").HasColumnType("datetime2").IsOptional();
            Property(x => x.DeleteDate).HasColumnName("DeleteDate").HasColumnType("datetime2").IsOptional();
            Property(x => x.Status).IsRequired();
        }
    }
}
