using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crm.DataAccessLayer.Abstract;
using Crm.DataAccessLayer.Repository;
using Crm.EntityLayer.Concrete;

namespace Crm.DataAccessLayer.EntityFrameWork
{
    public class EfRoleDal:GenericRepository<Role>,IRoleDal
    {
    }
}
