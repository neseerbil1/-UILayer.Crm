using Microsoft.AspNetCore.Mvc;

namespace UILayer.Crm.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404(int code)
        {

            return View();
        }
    }
}
