using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RoutingExample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                "Employee",
               "Employee/{name}",
                defaults: new
                { controller = "Employee",   action = "Search",name = UrlParameter.Optional
                });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional
               }
            );
            routes.MapRoute(
                name: "About",
                url: "Home/About",
                defaults: new { controller = "Home" , action ="About",id = UrlParameter.Optional
                }) ;
            
        
        }
    }
}
