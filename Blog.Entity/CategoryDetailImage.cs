using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entity
{
    public class CategoryDetailImage :EntityBase
    {
        public int CategoryDetailImageId { get; set; }

        public int CategoryDetailId { get; set; }

        public int Url { get; set; }

        public int FileName { get; set; }

    }
}
