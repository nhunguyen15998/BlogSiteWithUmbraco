using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using Umbraco.Core.Services;
using Umbraco.Web;

namespace BlogSiteWithUmbraco
{
    public class MvcApplication : Umbraco.Web.UmbracoApplication
        //System.Web.HttpApplication
    {
        protected new void Application_Start(object sender, EventArgs e)
        {
            var builder = new ContainerBuilder();

            // register all controllers found in your assembly
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // register Umbraco MVC + web API controllers used by the admin site
            builder.RegisterControllers(typeof(UmbracoApplication).Assembly);

            // add custom class to the container as Transient instance
            builder.RegisterType<IEntityService>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
