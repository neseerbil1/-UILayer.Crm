using Crm.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace UILayer.Crm.ViewComponents.Dashboard
{
    public class Widgets:ViewComponent
    {
        Context context=new Context();
        //Invoke:View Componentin görüntü parçası oluşturmak için kullandığı method
        public IViewComponentResult Invoke() 
        {
            ViewBag.v = context.Categories.Count();
            ViewBag.v2=context.Products.Count();
            return View(); 
        }
    }
}
