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

            routes.MapRoute(
              name: "TempSample",
              url: "Temp",
              defaults: new { controller = "JobPortal", action = "Index2", id = UrlParameter.Optional }
          );
            routes.MapRoute(
             name: "ViewBagSample",
             url: "Bag",
             defaults: new { controller = "JobPortal", action = "Index", id = UrlParameter.Optional }
         );

            routes.MapRoute(
                name: "Default",
                url: "Data",
                defaults: new { controller = "JobPortal", action = "Index1", id = UrlParameter.Optional }
            );
        }
    }
}
