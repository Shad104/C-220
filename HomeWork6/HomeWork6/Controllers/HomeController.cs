using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Models.BirthdayCardContent birthdayCardContent)
        {
            if (ModelState.IsValid)
                return View("BirthdayCardSent", birthdayCardContent);
            else
                return View();
        }
    }
}