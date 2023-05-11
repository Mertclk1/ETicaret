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
    public class FaturaManager : IFaturaService
    {
        IFaturaDal faturaDal;

        public FaturaManager(IFaturaDal faturaDal)
        {
            this.faturaDal = faturaDal;
        }

        public void TAdd(Fatura t)
        {
            faturaDal.Insert(t);
        }

        public void TDelete(Fatura t)
        {
            faturaDal.Delete(t);
        }

        public Fatura TGetByID(int id)
        {
            return faturaDal.GetByID(id);
        }

        public List<Fatura> TGetList()
        {
            return faturaDal.GetList();
        }

        public List<Fatura> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Fatura t)
        {
            faturaDal.Update(t);
        }
    }
}
