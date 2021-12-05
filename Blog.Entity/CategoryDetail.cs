using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entity
{
    public class CategoryDetail : EntityBase
    {
        public int CategoryDetailId { get; set; }

        public int CategoryId { get; set; }

        public string Header { get; set; }

        public string Content { get; set; }

        public string Description { get; set; }

    }
}
