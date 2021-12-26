using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Blog.BLL.Manager;
using Blog.Data;
using Blog.Helper;

namespace Blog.BLL
{
    public class DataService
    {
        private static object lockObject = new object();

        //_Context proeprtysi Manager sınıflarına parametre olarka gönderilir
        private static BlogDBContext _Context { get; set; }

        public DataService()
        {
            _Context = new BlogDBContext(ConnectionString);
        }
        public static string ConnectionString 
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings[GetContextName].ConnectionString;
                return connectionString;
            }
        }

        private static string GetContextName
        {
            get
            {
                return ConfigReader.GetConfigData("Context");
                //return ConfigurationManager.AppSettings["Context"].ToString();

            }
        }


        //Tüm managerlar DataServise eklenemk zorundadır 
        //Category Manager Inject Edilmesi
        private  CategoryManager _CategoryManager { get; set; }

        public  CategoryManager CategoryManager {
            get 
            {
                if (_CategoryManager == null)
                {
                    lock (lockObject)
                    {
                        if (_CategoryManager == null)
                        {
                            _CategoryManager = new CategoryManager(_Context);
                        }
                    }
                }
                return _CategoryManager;
            }     
        }

        private CategoryDetailManager _CategoryDetailManager { get; set; }

        public CategoryDetailManager CategoryDetailManager {
            get
            {

                if (_CategoryDetailManager==null)
                {
                    lock (lockObject)
                    {
                        if (_CategoryDetailManager == null)
                        {
                            _CategoryDetailManager = new CategoryDetailManager(_Context);
                        }
                    }  
                }

                return _CategoryDetailManager;
            }
       }

        private TagManager _TagManager { get; set; }

        public TagManager  TagManager {

            get
            {
                if (_TagManager == null)
                {
                    lock (lockObject)
                    {
                        if (_TagManager == null)
                        {
                            _TagManager = new TagManager(_Context);
                        }
                    }
                }

                return _TagManager;
            } 
       }


    }
}
