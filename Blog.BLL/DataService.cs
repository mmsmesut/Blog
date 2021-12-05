using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Blog.BLL
{
    public class DataService
    {
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
                return ConfigurationManager.AppSettings["Context"].ToString();
            }
        }

    }
}
