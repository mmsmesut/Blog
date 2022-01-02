using Blog.Data;
using Blog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BLL.Manager
{
    public class BlogHomePageManager : ManagerBase
    {
        public BlogHomePageManager(BlogDBContext context) : base(context)
        {

        }

        public List<BlogHomePageImage> BlogHomePageImages()
        {
            List<BlogHomePageImage> images = _context.BlogHomePageImages.ToList();
            return images;
        }
    }
}
