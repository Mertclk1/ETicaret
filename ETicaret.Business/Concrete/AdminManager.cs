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
    public class AdminManager : IAdminService
    {
        IAdminDal adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            this.adminDal = adminDal;
        }

        public void TAdd(Admin t)
        {
            adminDal.Insert(t);
        }

        public void TDelete(Admin t)
        {
            adminDal.Delete(t);
        }

        public Admin TGetByID(int id)
        {
            return adminDal.GetByID(id);
        }

        public List<Admin> TGetList()
        {
            return adminDal.GetList();
        }

        public List<Admin> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Admin t)
        {
            adminDal.Update(t);
        }
    }
}
