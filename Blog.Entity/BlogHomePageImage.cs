using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity
{
    public class BlogHomePageImage 
    {

        public int BlogHomePageImageId { get; set; }

        public byte[] ImageData { get; set; }  //C# tarafında Byte Dizisi Database tarafında ise Image olarak tutulur 

    }
}
