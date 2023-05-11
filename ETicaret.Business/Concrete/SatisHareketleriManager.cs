using E_Ticaret.Abstract;
using ETicaret.Business.Abstract;
using ETicaret.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Business.Concrete
{
    public class SatisHareketleriManager : ISatisHareketleriService
    {
        ISatisHareketleriDal satisHareketleriDal;

        public SatisHareketleriManager(ISatisHareketleriDal satisHareketleriDal)
        {
            this.satisHareketleriDal = satisHareketleriDal;
        }

        public void TAdd(SatisHareketleri t)
        {
            satisHareketleriDal.Insert(t);
        }

        public void TDelete(SatisHareketleri t)
        {
            satisHareketleriDal.Delete(t);
        }

        public SatisHareketleri TGetByID(int id)
        {
            return satisHareketleriDal.GetByID(id);
        }

        public List<SatisHareketleri> TGetList()
        {
            return satisHareketleriDal.GetList();
        }

        public List<SatisHareketleri> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SatisHareketleri t)
        {
            satisHareketleriDal.Update(t);
        }
    }
}
