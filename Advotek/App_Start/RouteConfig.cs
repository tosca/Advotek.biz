using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Advotek
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                "Index",
                "Index",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                "about",
                "About",
                defaults: new { controller = "Home", action = "Index#about", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                "services",
                "Services",
                defaults: new { controller = "Home", action = "Index#services", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                "clients",
                "Clients",
                defaults: new { controller = "Home", action = "Index#clients", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                "contact",
                "Contact",
                defaults: new { controller = "Home", action = "Index#contact", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "HPprinters",
               url: "HPprinters",
               defaults: new { controller = "Home", action = "HPprinters", id = UrlParameter.Optional }
           );

            routes.MapRoute(
              name: "HPproducts",
              url: "HPproducts",
              defaults: new { controller = "Home", action = "HPproducts", id = UrlParameter.Optional }
          );

            routes.MapRoute(
             name: "HPprinterFinder",
             url: "HPprinterFinder",
             defaults: new { controller = "Home", action = "HPprinterFinder", id = UrlParameter.Optional }
         );

            routes.MapRoute(
             name: "HPsuppliesFinder",
             url: "HPsuppliesFinder",
             defaults: new { controller = "Home", action = "HPsuppliesFinder", id = UrlParameter.Optional }
         );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}