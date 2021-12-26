using Blog.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.UI.Controllers
{
    public class CategoryDetailController : ControllerBase
    {
        // GET: CategoryDetail
        public PartialViewResult PopularAndRecentPartial()
        {

            PopularAndRecentPostResponseModel response = new PopularAndRecentPostResponseModel();
            response.PopularPost = DataService.CategoryDetailManager.GetPopularPost();
            response.RecentPost = DataService.CategoryDetailManager.GetRecentPost();
            return PartialView(response);
            //return PartialView("PopularAndRecentPartial", response);
        }
    }
}

