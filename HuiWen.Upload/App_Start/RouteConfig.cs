using Routes.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HuiWen.Upload
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            RoutingHelper.RegisterRoutes(routes, RouteMappingConfiguration.Current); //在Routes.config配置路由规则
        }
    }
}
