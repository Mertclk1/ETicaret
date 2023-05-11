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
    public class CariManager : ICariService
    {
        ICariDal cariDal;

        public CariManager(ICariDal cariDal)
        {
            this.cariDal = cariDal;
        }

        public void TAdd(Cari t)
        {
            cariDal.Insert(t);
        }

        public void TDelete(Cari t)
        {
            cariDal.Delete(t);
        }

        public Cari TGetByID(int id)
        {
            return cariDal.GetByID(id); 
        }

        public List<Cari> TGetList()
        {
           return cariDal.GetList();
        }

        public List<Cari> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Cari t)
        {
            cariDal.Update(t);
        }
    }
}
