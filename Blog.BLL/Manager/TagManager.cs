using Blog.BLL.Manager;
using Blog.Data;
using Blog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BLL.Manager
{
    public class TagManager : ManagerBase
    {
        public TagManager(BlogDBContext context) : base(context)
        {
        }

        public List<Tag> TagList()
        {
            List<Tag> tagList = _context.Tags.ToList();
            return tagList;
        }

    }
}
