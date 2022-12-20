using Crm.BusinessLayer.Absract;
using Crm.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace UILayer.Crm.Controllers
{
    public class CategoryController : Controller
    {
        
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListCategory()
        {
            //(serialization), bir veri yapısının bir dizi byte ya da karakter dizisine dönüştürülmesi           
            var values = JsonConvert.SerializeObject(_categoryService.TGetListAll());
            //JSON , yapılandırılmış verileri daha kolay okunabilir ve paylaşmak için veri biçimidir.
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _categoryService.TInsert(category);
            var values = JsonConvert.SerializeObject(category);
            return Json(values);
        }

    }
}
