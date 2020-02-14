using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;



namespace WebApplication1
{
    public class RouteConfig

    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

         //   routes.MapRoute(
         //     name: "Create",
         //     url: "Create",
         //     defaults: new { controller = "JobPortal", action = "Create", id = UrlParameter.Optional }
         // );
         //   routes.MapRoute(
         //    name: "View",
         //    url: "Delete",
         //    defaults: new { controller = "JobPortal", action = "Delete", id = UrlParameter.Optional }
         //);

            routes.MapRoute(
              name: "Default",
               url: "{controller}/{action}/{id}",
                defaults: new { controller = "JobPortal", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
