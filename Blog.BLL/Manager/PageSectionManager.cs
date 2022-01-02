using Blog.Data;
using Blog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BLL.Manager
{
    public class PageSectionManager : ManagerBase
    {
        public PageSectionManager(BlogDBContext context) : base(context)
        {

        }


        public List<PageSection> GetPageSectionsBySectionName(string name)
        {
            var sections = _context
                           .Database
                           .SqlQuery<PageSection>(@"declare @Name nvarchar(500) = {0}
                                                    select * from [dbo].[PageSection]
                                                    where Name like '%'+@Name+'%'",name)
                           .ToList();

            return sections;
        }

        public List<PageSection> GetPageSections()
        {
            var sections = _context
                           .Database
                           .SqlQuery<PageSection>(@"SELECT *  FROM PageSection")
                           .ToList();

            return sections;
        }

        public PageSectionContent GetPageSectionContentBySectionName(string name)
        {

            var section = GetPageSectionsBySectionName(name).FirstOrDefault();
            PageSectionContent contents = new PageSectionContent();
            if (section != null)
            {
                contents = _context
                            .Database
                            .SqlQuery<PageSectionContent>(@"declare @PageSectionId INT = {0}
                                                            SELECT *  FROM PageSectionContent
                                                            where PageSectionId =@PageSectionId", section.PageSectionId)
                            .FirstOrDefault();
            }


            return contents;
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
