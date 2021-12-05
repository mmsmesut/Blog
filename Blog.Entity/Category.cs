using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entity
{
    //[DataTable("Category")]
    public class Category : EntityBase
    {
        public int CategoryId { get; set; }

        public int ParentId { get; set; }

        public int OrderId { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

    }
}
