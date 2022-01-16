using Blog.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entity;
using Blog.Helper;
using Blog.Model.ResponseModel;
using System.Data.SqlClient;

namespace Blog.BLL.Manager
{
    public class CategoryDetailManager : ManagerBase
    {
        public CategoryDetailManager(BlogDBContext context) : base(context)
        {
        }

        public int GetPopularPostCount
        {
            get
            {
                return int.Parse(ConfigReader.GetConfigData("popularPostCount"));
            }
        }


        //public IEnumerable<CategoryDetail> GetPopularPost()
        //{
        //    //CategoryDetail c = new CategoryDetail();
        //    var list = _context.CategoryDetails.Where(c=>c.Deleted==false && c.IsPopular==true);
        //    return list;
        //}

        /*
        public List<CategoryDetail> GetPopularPost(int? postCount=3)
        {
            //Nullable<int> sayi; == int? sayi
            //CategoryDetail c = new CategoryDetail();

            var list = _context.CategoryDetails
                               .Where(c => c.Deleted == false && c.IsPopular == true)
                               .Take(postCount.Value) // İstenen kadar kayıt getirmeyi sağlar 
                               .ToList();
            return list;
        }


        public List<CategoryDetail> GetRecentPost(int? postCount = 3)
        {
            var list = _context.Database.
                               SqlQuery<CategoryDetail>(@"select * from CategoryDetail
                                                          order  by CreaDate desc")
                               .Take(postCount.Value)
                               .ToList();
            return list;
        }
        */


        public List<CategoryDetail> GetPopularPost()
        {
            //Nullable<int> sayi; == int? sayi
            //CategoryDetail c = new CategoryDetail();

            var list = _context.CategoryDetails
                               .Where(c => c.Deleted == false && c.IsPopular == true)
                               .Take(GetPopularPostCount) // İstenen kadar kayıt getirmeyi sağlar 
                               .ToList();
            return list;
        }


        public List<CategoryDetail> GetRecentPost()
        {
            var list = _context.Database.
                               SqlQuery<CategoryDetail>(@"select * from CategoryDetail
                                                          order  by CreaDate desc")
                               .Take(GetPopularPostCount)
                               .ToList();
            return list;
        }

        public List<CategoryDetailResponseModel> GetAllPost()
        {
            var list =         _context.Database.
                               SqlQuery<CategoryDetailResponseModel>(@"select Cm.Count as CommentCount,c.CategoryName,t.TagName,cd.CategoryDetailId,
                                                        Cd.Header,cd.Content
                                                        from CategoryDetail as cd
                                                        outer apply
                                                        (
                                                         select count(*) as Count from Comment as c where c.CategoryDetailId = cd.CategoryDetailId 
                                                        ) CM
                                                        inner join Category as c on c.CategoryId = cd.CategoryId and c.Deleted =0
                                                        inner join Tag as t on t.TagId = cd.TagId and c.Deleted =0
                                                        where cd.Deleted = 0

                                                        ")
                               .Take(GetPopularPostCount)
                               .ToList();
            return list;
        }

        public List<CategoryDetailResponseModel> GetAllPostByCategoriId(int catId)
        {
            var list = _context.Database.
                               SqlQuery<CategoryDetailResponseModel>(@"
                                                         declare @catId int = {0}
                                                         select* from CategoryDetail as cd where 
                                                         cd.CategoryId = @catId and cd.Deleted = 0
                                                         ", catId)
                               .ToList();
            return list;
        }


        public List<CategoryDetailResponseModel> GetAllPostByTagId(int tagId)
        {
            var list = _context.Database.
                               SqlQuery<CategoryDetailResponseModel>(@"
                                                         declare @tagId int = {0}
                                                         select* from CategoryDetail as cd where 
                                                         cd.TagId = @tagId and cd.Deleted = 0
                                                         ", tagId)
                               .ToList();
            return list;
        }


        //Kullanıcıın girdiği key bilgisinin database de CategoryDetail tablosunda arayıp geriye birsonuc döndürür
       
        public List<CategoryDetailResponseModel> PostBySearchKey(string key)
        {
            key = "%" + key +"%";
            var list = _context.Database.SqlQuery<CategoryDetailResponseModel>(@"
                                                   declare @stringToFind VARCHAR(max) = {0} 
                                                   EXEC sp_FindStringInTableV2 @stringToFind",key).ToList();
            return list;
        }

        //2.Yöntem
        /*
        public List<CategoryXResponseModel> PostBySearchKey(string key)
        {
            key += "%";
            var list = _context.Database.SqlQuery<CategoryXResponseModel>("sp_FindStringInTableV2 @param1", new SqlParameter("@param1", key)).ToList();
            return list;
        }
        */

    }
}