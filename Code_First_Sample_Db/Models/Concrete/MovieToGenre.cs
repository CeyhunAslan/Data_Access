using Code_First_Sample_Db.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Sample_Db.Models.Concrete
{
    [Table("MovieToGenres")] // Bu şekilde tablo'nun database'deli ismini balirlemiş olurum .aslında bunu burada yapmamıza gerek yok çünkü E.F. otomatik olarak yapıyor ama ben ellede yapılabileceğini göstermek için burada kullandım 
    public class MovieToGenre:BaseEntity
    {

        public int MoiveId { get; set; }
        public virtual Movie Movie { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
