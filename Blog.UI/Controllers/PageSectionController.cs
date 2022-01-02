using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.UI.Controllers
{
    public class PageSectionController : ControllerBase
    {
        // GET: PageSection
        public PartialViewResult GetRightWidget()
        {
            var content = DataService.PageSectionManager.GetPageSectionContentBySectionName("Blog Ana Sayfası");
            return PartialView("RightWidgetText", content);
        }
    }
}