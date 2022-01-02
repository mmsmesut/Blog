using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Model.ResponseModel
{
    public class CategoryDetailResponseModel
    {
        public int CategoryDetailId { get; set; }

        public string Header { get; set; }

        public string Content { get; set; }

        public string CategoryName { get; set; }

        public string TagName { get; set; }

        public int  CommentCount { get; set; }
 
    }
}
