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
    public class FaturaKalemManager : IFaturaKalemService
    {
        IFaturaKalemDal faturaKalemDal;

        public FaturaKalemManager(IFaturaKalemDal faturaKalemDal)
        {
            this.faturaKalemDal = faturaKalemDal;
        }

        public void TAdd(FaturaKalem t)
        {
            faturaKalemDal.Insert(t);
        }

        public void TDelete(FaturaKalem t)
        {
            faturaKalemDal.Delete(t);
        }

        public FaturaKalem TGetByID(int id)
        {
            return faturaKalemDal.GetByID(id);
        }

        public List<FaturaKalem> TGetList()
        {
            return faturaKalemDal.GetList();
        }

        public List<FaturaKalem> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(FaturaKalem t)
        {
            faturaKalemDal.Update(t);
        }
    }
}
