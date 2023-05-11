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
    public class GiderSiniflariManager : IGiderSiniflariService
    {
        IGiderSiniflariDal giderSiniflariDal;

        public GiderSiniflariManager(IGiderSiniflariDal giderSiniflariDal)
        {
            this.giderSiniflariDal = giderSiniflariDal;
        }

        public void TAdd(GiderSiniflari t)
        {
           giderSiniflariDal.Insert(t);
        }

        public void TDelete(GiderSiniflari t)
        {
            giderSiniflariDal.Delete(t);
        }

        public GiderSiniflari TGetByID(int id)
        {
           return giderSiniflariDal.GetByID(id);
        }

        public List<GiderSiniflari> TGetList()
        {
            return giderSiniflariDal.GetList();
        }

        public List<GiderSiniflari> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(GiderSiniflari t)
        {
            giderSiniflariDal.Update(t);
        }
    }
}
