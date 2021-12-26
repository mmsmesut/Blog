using Blog.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.UI.Controllers
{
    public class ControllerBase : Controller
    {
        public void Get()
        { }


        private static Object lockObject = new object();

        //Constructor metod
        public ControllerBase()
        {

        }

        private static DataService _DataService { get; set; }

        //Get Metodu 2 şekilde kullanılır a) set ve get'in bir arada kullanılması 
        //b) Sadece get'in kullanılması -> return olmak zorunda ve bir hesaplama ve işlem yapılma durumunda kullanılır 
        public static DataService DataService { 
            get
            {
                if (_DataService==null)
                {
                    lock (lockObject)
                    {
                        if (_DataService == null)
                        {
                            //DataService clasının bir instance'nı örenğini almışız
                            _DataService = new DataService();
                        }
                    }
                }
                return _DataService;
            }
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