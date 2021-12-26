using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Helper
{
    public class DateTimeHelper
    {
        const string dMy = "dd/MM/yyyy";
        const string yMd = "dd/MM/yyyy";

        public static string GetDate(DateTime dateTime)
        {
            var date = dateTime.ToString("dd/MM/yyyy");
            return date;
        }

        public static string GetDate(DateTime dateTime, DateFormatTypeEnum dateFormatTypeEnum)
        {
            string format = "";
            switch (dateFormatTypeEnum)
            {   
                case DateFormatTypeEnum.ddMMyyyy:
                    format = dMy;
                    break;
                case DateFormatTypeEnum.yyyyMMdd:
                    format = yMd;
                    break;
                default:
                    format = dMy;
                    break;
            }

            var date = dateTime.ToString(format);
            return date;
            //var date = dateTime.ToString("dd/MM/yyyy");
            //return date;
        }
    }

    public enum DateFormatTypeEnum
    { 
       ddMMyyyy = 1,
       yyyyMMdd = 2,
    }
}
