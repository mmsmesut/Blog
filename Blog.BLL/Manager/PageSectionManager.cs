using Blog.Data;
using Blog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BLL.Manager
{
    class PageSectionManager : ManagerBase
    {
        public PageSectionManager(BlogDBContext context) : base(context)
        {

        }

        public List<PageSectionContent> GetPageSectionContents()
        {
            var contents = _context
                           .Database
                           .SqlQuery<PageSectionContent>(@"SELECT *  FROM PageSectionContent")
                           .ToList();

            return contents;
        }
    }
}
