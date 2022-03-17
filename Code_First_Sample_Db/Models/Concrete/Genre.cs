using Code_First_Sample_Db.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Sample_Db.Models.Concrete
{
    [Table("Genres")] // Bu şekilde tablo'nun database'deli ismini balirlemiş olurum .aslında bunu burada yapmamıza gerek yok çünkü E.F. otomatik olarak yapıyor ama ben ellede yapılabileceğini göstermek için burada kullandım 
    public class Genre : BaseEntity
    {
        public string GenreName { get; set; }




        // many-to-many bir filmin birden çok türü olabilir(aksiyon , gerilim)
        public virtual List<MovieToGenre> MovieToGenres { get; set; }
    }
}
