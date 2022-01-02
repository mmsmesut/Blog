using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entity
{
    public class Comment : EntityBase
    {
        public int CommentId { get; set; }

        public int CategoryDetailId { get; set; }

        public string CommentContent { get; set; }

        public bool IsApproved { get; set; }

    }
}
