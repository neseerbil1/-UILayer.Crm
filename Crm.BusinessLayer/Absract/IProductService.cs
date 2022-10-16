﻿using Crm.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.BusinessLayer.Absract
{
    public interface IProductService:IGenericService<Product>
    {
        List<Product> TGetListWithCategory();
    }
}
