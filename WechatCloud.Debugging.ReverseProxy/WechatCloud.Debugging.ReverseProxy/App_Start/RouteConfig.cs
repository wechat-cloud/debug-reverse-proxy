using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WechatCloud.Debugging.ReverseProxy
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{siteBase64}",
                defaults: new { controller = "ReverseProxy", action = "Site", siteBase64 = "aHR0cDovL2x1cm9uZ2thaS5qaW9zLm9yZzo3MDgw" }
            );
        }
    }
}
