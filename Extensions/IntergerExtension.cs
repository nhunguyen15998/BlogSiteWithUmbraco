using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSiteWithUmbraco.Extensions
{
    public static class IntergerExtension
    {
        public static int sum(this object a ,int d)
        {
            return (int)a +d;
        }
        public static int getSize(this List<string> a)
        {
            return a.Count;
        }
    }
}