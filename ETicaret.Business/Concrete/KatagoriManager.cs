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
    public class KatagoriManager : IKatagoriService
    {
        IKatagoriDal katagoriDal;

        public KatagoriManager(IKatagoriDal katagoriDal)
        {
            this.katagoriDal = katagoriDal;
        }

        public void TAdd(Katagori t)
        {
            katagoriDal.Insert(t);
        }

        public void TDelete(Katagori t)
        {
            katagoriDal.Delete(t);
        }

        public Katagori TGetByID(int id)
        {
            return katagoriDal.GetByID(id);
        }

        public List<Katagori> TGetList()
        {
            return katagoriDal.GetList();
        }

        public List<Katagori> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Katagori t)
        {
            katagoriDal.Update(t);
        }
    }
}
