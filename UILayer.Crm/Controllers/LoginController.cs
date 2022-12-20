using Crm.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UILayer.Crm.Models;

namespace UILayer.Crm.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignInModel p)
        {
            if (ModelState.IsValid)
            {//persistent(bilgiyi bellekte tutar, beni hatırlasın mı),lockoutOnFailure(hatalı kullanımda kilitlensin mi)
                var result = await _signInManager.PasswordSignInAsync(p.Username, p.Password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index","Dashboard");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
    }
}
