using Blog.Data;
using Blog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BLL.Manager
{
    /*
     CategoryManager DataServis İçerisine inject edilir ve DataServis ile ilişkisi kurulmuş olur 
     */

    public class CategoryManager : ManagerBase
    {
        public CategoryManager(BlogDBContext context) : base(context)
        {
            
        }

        public List<Category> CategoriList()
        {
            List<Category> catList = _context.Categories.ToList();
            return catList;
        }

        public List<Category> TopThreeCatList()
        {
            List<Category> topThreeCatList = _context.Categories.ToList();
            return topThreeCatList;
        }


        public List<Category> CategoriList(int catId)
        {
            List<Category> catList = _context.Categories.Where(x=>x.CategoryId==catId && x.Deleted == false).ToList();
            return catList;
        }

    }
}
