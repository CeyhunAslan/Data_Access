using Code_First_Sample_Db.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Sample_Db.Models.Concrete
{
    [Table("Directors")] // Bu şekilde tablo'nun database'deli ismini balirlemiş olurum .aslında bunu burada yapmamıza gerek yok çünkü E.F. otomatik olarak yapıyor ama ben ellede yapılabileceğini göstermek için burada kullandım 
    public class Director : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }


        //Bir Dicrector birden çok Movie'de yer alabilir.
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
