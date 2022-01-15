using Blog.Model.ResponseModel;
using PagedList;
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
     
        //Ana sayfa içerindeki postları sayfalayarak getirir 
        public ActionResult Index(int page = 1)
        {
            IPagedList<CategoryDetailResponseModel> response = DataService.CategoryDetailManager.GetAllPost().ToPagedList(page, BlogPostCountForEveryPage);
            return View(response);
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



