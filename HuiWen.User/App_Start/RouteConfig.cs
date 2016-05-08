using Routes.Routing;
using System.Web.Mvc;
using System.Web.Routing;

namespace HuiWen.User
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            RoutingHelper.RegisterRoutes(routes, RouteMappingConfiguration.Current); //在Routes.config配置路由规则

           // routes.MapRoute(
           //    "Default",                                              // Route name
           //    "{controller}/{action}/{id}",                           // URL with parameters
           //    new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
           //);
        }
    }
}
