using Crm.BusinessLayer.Concrete;
using Crm.DataAccessLayer.EntityFrameWork;
using Crm.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace UILayer.Crm.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        public IActionResult Index()
        {
            var values = productManager.TGetListWithCategory();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            List<SelectListItem> values = (from x in categoryManager.TGetListAll()
                                           select new SelectListItem
                                           {
                                              Text=x.CategoryName,
                                              Value=x.CategoryID.ToString()
                                           }).ToList(); 
            ViewBag.v=values;
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            productManager.TInsert(product);
            return RedirectToAction("Index");
        }
    }
}
