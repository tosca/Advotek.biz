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
            name: "HPbusinessUpgradeTool",
            url: "HPbusinessUpgradeTool",
            defaults: new { controller = "Home", action = "HPbusinessUpgradeTool", id = UrlParameter.Optional }
        );

            routes.MapRoute(
            name: "HPeliteBookFamily",
            url: "HPeliteBookFamily",
            defaults: new { controller = "Home", action = "HPeliteBookFamily", id = UrlParameter.Optional }
        );

            routes.MapRoute(
            name: "HPenterpriseGroup",
            url: "HPenterpriseGroup",
            defaults: new { controller = "Home", action = "HPenterpriseGroup", id = UrlParameter.Optional }
        );

            routes.MapRoute(
            name: "HPhelpdesk",
            url: "HPhelpdesk",
            defaults: new { controller = "Home", action = "HPhelpdesk", id = UrlParameter.Optional }
        );

            routes.MapRoute(
            name: "HPimagePrintPromo",
            url: "HPimagePrintPromo",
            defaults: new { controller = "Home", action = "HPimagePrintPromo", id = UrlParameter.Optional }
        );


            routes.MapRoute(
            name: "HPK12Education",
            url: "HPK12Education",
            defaults: new { controller = "Home", action = "HPK12Education", id = UrlParameter.Optional }
        );

            routes.MapRoute(
            name: "HPmobility",
            url: "HPmobility",
            defaults: new { controller = "Home", action = "HPmobility", id = UrlParameter.Optional }
        );

            routes.MapRoute(
            name: "HPofficeProFamily",
            url: "HPofficeProFamily",
            defaults: new { controller = "Home", action = "HPofficeProFamily", id = UrlParameter.Optional }
        );

            routes.MapRoute(
            name: "HPPCupgradetool",
            url: "HPPCupgradetool",
            defaults: new { controller = "Home", action = "HPPCupgradetool", id = UrlParameter.Optional }
        );

            routes.MapRoute(
            name: "HPPrintImageCarePack",
            url: "HPPrintImageCarePack",
            defaults: new { controller = "Home", action = "HPPrintImageCarePack", id = UrlParameter.Optional }
        );

            routes.MapRoute(
            name: "HPproFamily",
            url: "HPproFamily",
            defaults: new { controller = "Home", action = "HPproFamily", id = UrlParameter.Optional }
        );

            routes.MapRoute(
            name: "HPscanJetScanners",
            url: "HPscanJetScanners",
            defaults: new { controller = "Home", action = "HPscanJetScanners", id = UrlParameter.Optional }
        );

            routes.MapRoute(
            name: "HPwindows10",
            url: "HPwindows10",
            defaults: new { controller = "Home", action = "HPwindows10", id = UrlParameter.Optional }
        );

            routes.MapRoute(
            name: "HPworkstationFamily",
            url: "HPworkstationFamily",
            defaults: new { controller = "Home", action = "HPworkstationFamily", id = UrlParameter.Optional }
        );

            routes.MapRoute(
            name: "originalHPsupplies",
            url: "originalHPsupplies",
            defaults: new { controller = "Home", action = "originalHPsupplies", id = UrlParameter.Optional }
        );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}