using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Helper
{
    public class ConfigReader
    {
        /// <summary>
        /// keyName is Paramater
        /// </summary>
        /// <param name="keyName"></param>
        /// <returns>This methot read data of key from Config file</returns>
        public static string GetConfigData(string keyName)
        {
            var keyData = ConfigurationManager.AppSettings[keyName].ToString();
            return keyData;
        }


        public static string GetConfigDataForPostCount(string popularPostCount)
        {
            var keyData = ConfigurationManager.AppSettings[popularPostCount].ToString();
            return keyData;
        }

    }
}
