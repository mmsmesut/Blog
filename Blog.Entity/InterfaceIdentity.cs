using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entity
{
    public interface InterfaceIdentity
    {
        int Id { get; set; }

        void CheckId();
    }
}
