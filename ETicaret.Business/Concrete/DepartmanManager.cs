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
    public class DepartmanManager : IDepartmanService
    {
        IDepartmanDal departmanDal;

        public DepartmanManager(IDepartmanDal departmanDal)
        {
            this.departmanDal = departmanDal;
        }

        public void TAdd(Departman t)
        {
            departmanDal.Insert(t);
        }

        public void TDelete(Departman t)
        {
            departmanDal.Delete(t);
        }

        public Departman TGetByID(int id)
        {
            return departmanDal.GetByID(id);
        }

        public List<Departman> TGetList()
        {
            return departmanDal.GetList();
        }

        public List<Departman> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Departman t)
        {
            departmanDal.Update(t);
        }
    }
}
