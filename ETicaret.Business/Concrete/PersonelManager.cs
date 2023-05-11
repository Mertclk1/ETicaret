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
    public class PersonelManager : IPersonelService
    {
        IPersonelDal personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            this.personelDal = personelDal;
        }

        public void TAdd(Personel t)
        {
            personelDal.Insert(t);
        }

        public void TDelete(Personel t)
        {
            personelDal.Delete(t);
        }

        public Personel TGetByID(int id)
        {
            return personelDal.GetByID(id);
        }

        public List<Personel> TGetList()
        {
           return personelDal.GetList();
        }

        public List<Personel> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Personel t)
        {
            personelDal.Update(t);
        }
    }
}
