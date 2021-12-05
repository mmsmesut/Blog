using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entity
{
    public class EntityBase
    {
        public DateTime CreaDate { get; set; } = DateTime.Now;

        public int CreaUser { get; set; } = 999; // Admin User 

        public int Deleted { get; set; } 

        public int UpdateDate { get; set; } 

    }
}
