using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.UI.Controllers
{
    public class HomeController : ControllerBase
    {
        // GET: Home
        public ActionResult Index()
        {
            var simdikiTarih = GetDateTimeBow;
            return View();
        }
    }
}



//OOP
//Bundele
