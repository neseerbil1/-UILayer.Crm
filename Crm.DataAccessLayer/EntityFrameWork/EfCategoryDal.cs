﻿using Crm.DataAccessLayer.Abstract;
using Crm.DataAccessLayer.Repository;
using Crm.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.DataAccessLayer.EntityFrameWork
{
    public class EfCategoryDal:GenericRepository<Category>,ICategoryDal
    {
    }
}
