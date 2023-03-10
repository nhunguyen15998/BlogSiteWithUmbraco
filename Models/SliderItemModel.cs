using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace BlogSiteWithUmbraco.Models
{
    public class SliderItemModel
    {
        public int SliderImage { get; set; }
        public int SliderUrl { get; set; }
        public string SliderTitle { get; set; }
        public string FirstLineText { get; set; }
        public string ShortDescription { get; set; }
    }
}