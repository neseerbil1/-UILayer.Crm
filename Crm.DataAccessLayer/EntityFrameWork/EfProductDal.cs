using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crm.DataAccessLayer.Abstract;
using Crm.DataAccessLayer.Concrete;
using Crm.DataAccessLayer.Repository;
using Crm.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Crm.DataAccessLayer.EntityFrameWork
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        Context context = new Context();
        public List<Product> GetListProductWithCategory()
        {
            return context.Products.Include(x => x.Category).ToList(); 
        }
    }
}
