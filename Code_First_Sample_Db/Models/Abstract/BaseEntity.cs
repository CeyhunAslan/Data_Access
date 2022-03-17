using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Sample_Db.Models.Abstract
{
    public abstract class BaseEntity
    {
        // Tüm alt sınıflarımın ortak özellikleri kalıtım yoluyla BaseEntity.cs sınıfımda gelicek

        //Entity framework "Id" isimli bir proprty otomatik olarak Primary Key ve Identity olarak işaretler. Bunu default olarak oalrak yapar. Lakin ben eşşeğimi sağalam kazığa bağalarım diyen arkadaşlar için bunu elle yapmamaızada müsade eder. 
        [Key] //Id property'sini PK yaptık.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Id alanına SQL'deki Identity mantığını kazandırdık.
        public  int Id { get; set;  }
        
        
        //Not: şayet Ef Id alanını görmezse göç (migration) esnasında bize hata fırlatır. 
    }
}
