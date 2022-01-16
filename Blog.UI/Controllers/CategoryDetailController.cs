using Blog.Model.ResponseModel;
using Blog.UI.Models;
using PagedList;
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



        public PartialViewResult GetAllPost(int pageId=1)
        {
            IPagedList<CategoryDetailResponseModel> response = DataService.CategoryDetailManager.GetAllPost().ToPagedList(pageId,3);
            return PartialView("HomePageBlogPostPartial", response);
        }

        public ActionResult PostByCategory(int ?id, int page = 1)
        {
            IPagedList<CategoryDetailResponseModel> response = DataService.CategoryDetailManager.GetAllPostByCategoriId(id.Value).ToPagedList(page, BlogPostCountForEveryPage);
            return View(response);
        }


        public ActionResult PostByTag(int? id, int page = 1)
        {
            IPagedList<CategoryDetailResponseModel> response = DataService.CategoryDetailManager.GetAllPostByTagId(id.Value).ToPagedList(page, BlogPostCountForEveryPage);
            return View(response);
        }


        public ActionResult PostBySearchKey(string key,int page=1)
        {
            IPagedList<CategoryDetailResponseModel> response = DataService.CategoryDetailManager.PostBySearchKey(key).ToPagedList(page, BlogPostCountForEveryPage);
            return View(response);
            //var response = DataService.CategoryDetailManager.PostBySearchKey(key);
            //return View(response);
        }

    }
}

