using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvenOddCheckerMVC.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            Random rnd = new Random();
            int num = rnd.Next(11);
            ViewBag.num = num;
            return View();
        }
    }
}