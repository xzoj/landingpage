using LandingPageMP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LandingPageMP.Controllers
{
    public class LandingPageController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: LandingPage
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SendMessage([Bind(Include = "Id,Name,Email,Phone,Message")]Information info)
        {
            info.Status = Information.EnumStatus.New;
            info.CreateAt = DateTime.Now;
            ViewBag.Message = "error";
            if (ModelState.IsValid)
            {
                db.Information.Add(info);
                db.SaveChanges();
                ViewBag.Message = "success";
                return RedirectToAction("Index");
            } 
            
            return View("Index");
        }
        public ActionResult Test()
        {
            return View();
        }
    }
}