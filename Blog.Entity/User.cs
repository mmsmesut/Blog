using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entity
{
    public class User  : EntityBase
    {
        public int UserId { get; set; }

        public string NameSurname { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

    }
}
