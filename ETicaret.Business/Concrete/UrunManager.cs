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
    public class UrunManager : IUrunService
    {
        IUrunDal urunDal;

        public UrunManager(IUrunDal urunDal)
        {
            this.urunDal = urunDal;
        }

        public void TAdd(Urun t)
        {
            urunDal.Insert(t);
        }

        public void TDelete(Urun t)
        {
            urunDal.Delete(t);
        }

        public Urun TGetByID(int id)
        {
            return urunDal.GetByID(id); 
        }

        public List<Urun> TGetList()
        {
            return urunDal.GetList();
        }

        public List<Urun> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Urun t)
        {
           urunDal.Update(t);
        }
    }
}
