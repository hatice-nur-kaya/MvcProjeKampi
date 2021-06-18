using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
   public interface IAdminService
    {
        List<Admin> GetList();
        Admin GetById(int id);
        void Add(Admin admin);
        void Update(Admin admin);
        void Delete(Admin admin);
    }
}
