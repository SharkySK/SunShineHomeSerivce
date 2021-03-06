﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HomeCare
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                "Admin",
                "{action}/{id}",
                defaults: new { controller = "Home", action = "Login", id = UrlParameter.Optional }
                );
            routes.MapRoute(
              name: "Admin",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Login", id = UrlParameter.Optional }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Login", id = UrlParameter.Optional }
            );
        }
    }
}
