using Code_First_Sample_Db.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Sample_Db.Models.Concrete
{
    [Table("Movies")] // Bu şekilde tablo'nun database'deli ismini balirlemiş olurum .aslında bunu burada yapmamıza gerek yok çünkü E.F. otomatik olarak yapıyor ama ben ellede yapılabileceğini göstermek için burada kullandım 
    public class Movie : BaseEntity
    {
        // database'e gidince oluşacak tablolarımın sutunları
        public int DirectorId { get; set; }
        public int GenreId { get; set; }
        public string Title { get; set; }

        [Column(TypeName = "datetime2", Order = 4)] //ReleaseYear Property'si veri tabanında datetime2 tipinde oluşacak. Ayrıca "Order" bilgisi ile sütun sırasını belirlerim.
        public DateTime ReleaseYear { get; set; }
        public bool Like { get; set; }


        //Relation
        // İlişkisel veri tabanı kullandığımız için ve Code First yaklaşımında veri tabanın yansıması bu tarafta yapıldığından ilişkileride burada kurmamız gerekmketedir.

        //Bir Film'in bir dicrector(yöentmeni)'u olabilir.

        public virtual Director Director { get; set; }


        // many-to-many Movie-Genre bir filmin birden çok türü olabilir(aksiyon , gerilim)
        public virtual List<MovieToGenre> MovieToGenres { get; set; }


        //many-to-many Movie-Actor Bir film'in birden fazla actor'u olabilir.
        public virtual List<MovieToActor> MovieToActors { get; set; }

    }
}
