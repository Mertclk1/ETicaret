using E_Ticaret.Abstract;
using ETicaret.DataAccess.Abstract;
using ETicaret.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccess.EntityFramework
{
    public class EfSatisHareketleriDal : GenericRepository<SatisHareketleri>, ISatisHareketleriDal
    {
    }
}
