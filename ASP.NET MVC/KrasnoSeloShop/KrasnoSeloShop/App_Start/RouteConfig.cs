using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace KrasnoSeloShop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.MapRoute(
            //    name: "HomePage",
            //    url: "",
            //    defaults: new { controller = "MyHome", action = "Index" }
            //);
            routes.MapRoute(
                "InProgressPage",
                "InProgress",
                new { controller = "Catalogues", action = "InProgress" }
                );
            routes.MapRoute(
                "SwimsuitPage",
                "Swimsuits",
                new { controller = "Catalogues", action = "Swimsuits" }
                );
            routes.MapRoute(
                name:"JeansPage",
                url: "Jeans",
                defaults: new { controller = "Catalogues", action = "Jeans" }
                );
            routes.MapRoute(
                name: "TshirtsPage",
                url: "Tshirts",
                defaults: new { controller = "Catalogues", action = "Tshirts" }
                );
            routes.MapRoute(
                name: "ChooseSeasonPage",
                url: "Seasons",
                defaults: new { controller = "Catalogues", action = "Seasons" }
                );
            routes.MapRoute(
                "AboutPage",
                "About",
                new { controller = "MyHome", action = "About"}
                );
            routes.MapRoute(
                "ContactsPage",
                "Contacts",
                new { controller = "MyHome", action = "Contacts" }
                );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "MyHome", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
