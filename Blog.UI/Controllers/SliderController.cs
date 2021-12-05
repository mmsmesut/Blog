using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.UI.Controllers
{
    public class SliderController : ControllerBase
    {
        // GET: Slider
        public ActionResult Index()
        {
            return View();
        }
    }
}