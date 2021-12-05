using Blog.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.BLL.Manager
{
    public class ManagerBase
    {
        //Dependency Injection

        public BlogDBContext _context { get; set; }

        private static object lockContext = new object();

        public ManagerBase(BlogDBContext context)
        {
            //Singleton design pattern 
            if (_context == null)
            {
                lock (lockContext)
                {
                    if (_context == null)
                    {
                        _context = new BlogDBContext(DataService.ConnectionString);
                    }
                }
            }
          
        }
    }
}
