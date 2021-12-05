using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Entity
{
    public class Slider : EntityBase
    {
        public int SliderId { get; set; }

        public string Header { get; set; }

        public string HeaderSmall { get; set; }

        public string Detail { get; set; }

        public string Url { get; set; }

        public string FileName { get; set; }

        public string DescriptionUrl { get; set; }

    }
}
