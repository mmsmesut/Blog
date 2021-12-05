using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entity
{
    public class Role : EntityBase
    {
        public int RoleId { get; set; }

        public string RoleName { get; set; }
    }
}
