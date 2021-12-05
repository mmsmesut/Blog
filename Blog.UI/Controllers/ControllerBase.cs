using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.UI.Controllers
{
    public class ControllerBase : Controller
    {
        //Constructor metod
        public ControllerBase()
        {

        }

        public int UserName { get; set; }

        public DateTime GetDateTimeBow {

            get
            {
                return DateTime.Now;
            }
        
        }

    }
}