using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Helper
{
    public class ImageHelper
    {

        public static string GetBase64ImageString()
        {
            var path = "data:image/jpg;base64";
            return path;
        }

    }
}
