using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entity
{
    public class EntityBase
    {
        public DateTime CreaDate { get; set; } = DateTime.Now;

        public int? CreaUser { get; set; } = 999; // Admin User 

        public bool Deleted { get; set; } 

        public Nullable<DateTime> UpdateDate { get; set; } 

    }
}
