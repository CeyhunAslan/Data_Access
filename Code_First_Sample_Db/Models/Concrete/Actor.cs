using Code_First_Sample_Db.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Sample_Db.Models.Concrete
{
    [Table("Actors")] // Bu şekilde tablo'nun database'deli ismini balirlemiş olurum .aslında bunu burada yapmamıza gerek yok çünkü E.F. otomatik olarak yapıyor ama ben ellede yapılabileceğini göstermek için burada kullandım 
    public class Actor:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public String Nationality { get; set; }




        [Column(TypeName = "datetime2", Order = 4)] //BirthDate Property'si veri tabanında datetime2 tipinde oluşacak. Ayrıca "Order" bilgisi ile sütun sırasını belirlerim.
        public DateTime BirthDate { get; set; }


        //many-to-many Movie-Actor Bir filmin birden fazla oyuncusu olabilir.
        public virtual List<MovieToActor> MovieToActors { get; set; }

    }
}
