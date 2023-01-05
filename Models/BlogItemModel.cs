using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSiteWithUmbraco.Models
{
    public class BlogItemModel
    {
        public int Index { get; set; }
        public string Title { get; set; }
        public string BlogUrl { get; set; }
        public int Thumbnail { get; set; }
        public string ShortDescription { get; set; }
        public string Content { get; set; }
        public int Category { get; set; }
    }
}