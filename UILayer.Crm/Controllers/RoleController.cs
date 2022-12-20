using Crm.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using UILayer.Crm.Models;

namespace UILayer.Crm.Controllers
{
    public class RoleController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public RoleController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            //veritabanında kayıtlı olan tüm roller bu özellik aracılığıyla erişilebilir.
            var values =_roleManager.Roles.ToList();
            return View(values);  
        }

        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(AppRole role)
        {
            var result=await _roleManager.CreateAsync(role);    
            if(result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
       
        public async Task<IActionResult> DeleteRole(int id)
        {
            var role = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            var result = await _roleManager.DeleteAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult UpdateRole(int id)
        {
            var role = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            return View(role);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRole(AppRole role)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == role.Id);
            values.Name = role.Name;
            var result = await _roleManager.UpdateAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult UserList()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }
        public async Task<IActionResult> AssignRole(int id)
        {
            var user=_userManager.Users.FirstOrDefault(x => x.Id == id);
            var roles = _roleManager.Roles.ToList();
            TempData["UserId"] = user.Id;
            var userRoles = await _userManager.GetRolesAsync(user);
            List<RoleAssignViewModel> models = new List<RoleAssignViewModel>(); 
            foreach(var item in roles)
            {
                RoleAssignViewModel model=new RoleAssignViewModel();
                model.RoleId = item.Id;
                model.Name=item.Name;   
                models.Add(model);  

            }
            return View(models);
        }
       
        [HttpGet]
       
        public async Task<IActionResult> AssignRole2(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);            
            var roles = _roleManager.Roles.ToList();

            TempData["UserId"] = user.Id;
            var userRoles = await _userManager.GetRolesAsync(user);

            List<RoleAssignViewModel> models = new List<RoleAssignViewModel>();
            foreach (var item in roles)
            {
                RoleAssignViewModel m = new RoleAssignViewModel();
                m.RoleId = item.Id;
                m.Name = item.Name;            
                m.Exists = userRoles.Contains(item.Name);            
                models.Add(m);
            }
            return View(models);
        }
        [HttpPost]
        //Birden fazla rol alabileceği için liste tipinde
        public async Task<IActionResult> AssignRole2(List<RoleAssignViewModel> model)
        {
            //102. satırdaki id'yi taşımak için tempdata kullanılıyor Aynı viewde çalıştığı için
            var userid = (int)TempData["UserId"];
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userid);

            foreach (var item in model)
            {
                if (item.Exists)
                {
                    await _userManager.AddToRoleAsync(user, item.Name);
                }
                 
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.Name);
                }
            }
            return RedirectToAction("UserList");

        }

    }
}
