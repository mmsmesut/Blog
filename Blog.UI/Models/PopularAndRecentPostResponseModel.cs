using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Blog.Entity;

namespace Blog.UI.Models
{
    public class PopularAndRecentPostResponseModel
    {
        public List<CategoryDetail> PopularPost { get; set; } = new List<CategoryDetail>();
        public List<CategoryDetail> RecentPost { get; set; } = new List<CategoryDetail>();

    }
}

