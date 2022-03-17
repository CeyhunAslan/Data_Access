using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_CRUD
{
    public class Kitap
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SeriesName { get; set; }
        public string Author { get; set; }
    }
}
