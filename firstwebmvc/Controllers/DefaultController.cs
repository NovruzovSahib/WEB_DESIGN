using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using firstwebmvc.Models.classes;
namespace firstwebmvc.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Context C = new Context();
            var deyer = C.bacarıqlars.ToList();
            return View(deyer);
        }
    }
}