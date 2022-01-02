using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.UI.Controllers
{

    //Controllerda bulunan action adlarını İlgili klasörde arara bulamaz ise Shared klasöründe arar
    public class HomeController : ControllerBase
    {
        // GET: Home
        public ActionResult Index()
        {

          
             var simdikiTarih = GetDateTimeBow;
             return View();
        }

        public PartialViewResult HeadPartial()
        {
            var catList = DataService.CategoryManager.CategoriList();
            return PartialView(catList);//MVC de KOntrollerdan view'e veri gönderme Yöntemi View içerisine direk veri gömülür ve View tarafında veri alınır
        }

        public PartialViewResult RightCategoryPartial()
        {
            var catList = DataService.CategoryManager.CategoriList();
            return PartialView(catList);//MVC de KOntrollerdan view'e veri gönderme Yöntemi View içerisine direk veri gömülür ve View tarafında veri alınır
        }


        public PartialViewResult RecentFlickrImages()
        {
            var images = DataService.BlogHomePageManager.BlogHomePageImages();
            return PartialView("RecentFlickrImagesPartial", images);
        }

    }
}



