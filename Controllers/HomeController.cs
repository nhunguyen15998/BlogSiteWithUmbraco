using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace BlogSiteWithUmbraco.Controllers
{
    public class HomeController : SurfaceController
    {
        // GET: Home
        public ActionResult Home()
        {
            return View();
        }
    }
}