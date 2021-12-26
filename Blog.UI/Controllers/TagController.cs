using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.UI.Controllers
{
    public class TagController : ControllerBase
    {
        // GET: GetAllTags
        public PartialViewResult GetAllTags()
        {
            var tagList = DataService.TagManager.TagList();
            return PartialView("TagPartial", tagList);
        }
    }
}