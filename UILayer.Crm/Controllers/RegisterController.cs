using Crm.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UILayer.Crm.Models;

namespace UILayer.Crm.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignUp p)
        {

            AppUser user = new AppUser()
            {
                Email = p.Mail,
                Name = p.Name,
                Surname = p.Surname,
                Gender = p.Gender,
                UserName = p.Username,

            };
            if (p.Password == p.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(user, p.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index","Login");
                }

                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                }

            }
                    return View();  
        }
    }
}
    

