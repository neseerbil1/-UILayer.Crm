using Microsoft.AspNetCore.Mvc;

namespace UILayer.Crm.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
