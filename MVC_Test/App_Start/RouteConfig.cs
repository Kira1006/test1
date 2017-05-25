using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Test
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                "Customer",
 "{controller}/{action}/{name}",
 new
 {
     controller = "Customer",
     action = "GetAllCustomers",
     name =
         UrlParameter.Optional
 });
            
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                "Employee",
 "{controller}/{action}/{name}",
 new
 {
     controller = "Employee",
     action = "Search",
     name =
         UrlParameter.Optional
 });

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "Process",
            url: "Process/{action}/{id}",
            defaults: new
            {
                controller = " Process",
                action = "List",
                id =
                    UrlParameter.Optional
            }
            );



        }
    }
}
