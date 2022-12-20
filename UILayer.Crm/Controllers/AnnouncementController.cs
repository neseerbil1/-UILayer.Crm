using Crm.BusinessLayer.Absract;
using Crm.DTO.DTOs.AnnouncementDtos;
using Crm.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace UILayer.Crm.Controllers
{
    [AllowAnonymous]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDto p)
        {
            if (ModelState.IsValid)
            {
                //Insert parametresi announcement türünde değişken istiyor
                _announcementService.TInsert(new Announcement()
                {
                    Title = p.Title,
                    Publisher = p.Publisher,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}