using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity
{
    public class PageSectionContent : EntityBase
    {
        public int PageSectionContentId { get; set; }

        public int PageSectionId { get; set; }

        public string Header { get; set; }

        public string Content { get; set; }

        public string Footer { get; set; }

        public string Description { get; set; }

    }
}
