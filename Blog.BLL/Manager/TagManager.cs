using Blog.BLL.Manager;
using Blog.Data;
using Blog.Entity;
using Blog.Model.ResponseModel;
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

        //public List<Tag> TagList()
        //{
        //    List<Tag> tagList = _context.Tags.ToList();
        //    return tagList;
        //}

        public List<TagResponseModel> TagList()
        {
            List<TagResponseModel> tagList = _context.Database.SqlQuery<TagResponseModel>(@"
                                                select t.TagId, t.TagName, count(CategoryDetailId) as TagCount
                                                from Tag as t
                                                left join CategoryDetail as cd on t.TagId = cd.TagId and cd.Deleted = 0 and t.Deleted= 0
                                                group by t.TagId, t.TagName
                                                ").ToList();
            return tagList;
        }




    }
}
