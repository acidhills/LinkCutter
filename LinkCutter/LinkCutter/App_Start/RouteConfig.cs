using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LinkCutter
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                "Redirect",
                "{linkId}",
                new { controller = "Redirect", action = "Index" },
                new { linkId = @"\d+" }
            );
            routes.MapRoute(
                "GUI_default",
                "{*url}",
                new { controller = "Gui", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
