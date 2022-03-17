using LibraryProject.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Infrastructure.Repositories.Abstract
{
    public abstract class KernelRepository
    {
        //Her bir repository içerisinde tek tek AppDbContext new'lememek için buradan new'leyerek dağıtacağım
        protected AppDbContext db;

        public KernelRepository()
        {
            db = new AppDbContext();
        }

        //İKi constructor aynı işi yapar. Kısa yazımı aşağıdadır.
        //public KernelRepository() => db = new AppDbContext();
    }
}
