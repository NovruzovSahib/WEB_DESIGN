using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using firstwebmvc.Models.classes;

namespace firstwebmvc.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();

        public ActionResult Index()
        {

            var deyer = c.bacarıqlars.ToList();
            return View(deyer);
        }
        [HttpGet]
        public ActionResult Skill1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Skill1(Bacarıqlar b)
        {
            c.bacarıqlars.Add(b);
            c.SaveChanges();
            return View();
        }
        public ActionResult Deleteskill(int id)
        {
            var deyer = c.bacarıqlars.Find(id);
            c.bacarıqlars.Remove(deyer);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var deyer = c.bacarıqlars.Find(id);
            return View("UpdateSkill",deyer);
        }
        [HttpPost]
        public ActionResult UpdateSkill(Bacarıqlar y)
        {
            var x = c.bacarıqlars.Find(y.Id);
            x.aciqlama = y.aciqlama;
            x.deyer = y.deyer;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
            
    }
}