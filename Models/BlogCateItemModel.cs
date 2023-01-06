using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;

namespace BlogSiteWithUmbraco.Models
{
    public class BlogCateItemModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CategorySlug { get; set; }
        public List<IPublishedContent> ListBlog { get; set; }
    }
}