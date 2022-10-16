using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrurchasePrice { get; set; }
        public double ProductSalePrice { get; set; }
        public string ProductImage { get; set; }
        public int ProductStock { get; set; }
        public string ProductCode { get; set; }
        public Category Category { get; set; }
        public int CategoryID { get; set; }
    }
}
