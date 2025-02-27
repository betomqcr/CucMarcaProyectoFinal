﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CUCMarca.WebSite
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Login",
                url: "{controller}/{action}/{modulo}",
                defaults: new { controller = "Login", action = "Index", modulo = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "Exepcion",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Exepcion", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}
