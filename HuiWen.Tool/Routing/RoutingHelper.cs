using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace HuiTu.Utilities.Configuration.Routing
{
    public static class RoutingHelper
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            RouteMappingConfiguration config = RouteMappingConfiguration.Current;
            RegisterRoutes(routes, config);
        }

        public static void RegisterRoutes(RouteCollection routes, RouteMappingConfiguration config)
        {
            if (config == null)
            {
                throw new NullReferenceException("路由映射配置没有定义");
            }
            using (routes.GetWriteLock())
            {
                if (config.Routes.RouteExistingFiles != null) routes.RouteExistingFiles = (bool)config.Routes.RouteExistingFiles;

                foreach (RouteElement ignoreItem in config.IgnoreRoutes)
                {
                    routes.IgnoreRoute(ignoreItem.Url);
                }

                foreach (RouteElement item in config.Routes)
                {
                    var lowerCaseOnly = item.LowerCaseOnly == null ? config.Routes.LowerCaseOnly : item.LowerCaseOnly.Value;
                    var route = new RegRoute.StrictRoute(item.Url, new MvcRouteHandler(), lowerCaseOnly);
                    route.Defaults = new RouteValueDictionary();
                    route.Defaults.Add("Controller", item.Controller);
                    route.Defaults.Add("Action", item.Action);

                    if (item.Defaults != null)
                    {
                        foreach (string key in item.Defaults.AllKeys)
                        {
                            route.Defaults.Add(key, item.Defaults[key].Value);
                        }
                    }
                    if (item.Constraints != null)
                    {
                        route.Constraints = new RouteValueDictionary();
                        foreach (string key in item.Constraints.AllKeys)
                        {
                            route.Constraints.Add(key, new RegRoute.RegexConstraint(item.Constraints[key].Value));
                        }
                    }
                    if (item.Namespace != null)
                    {
                        if (route.DataTokens == null)
                        {
                            route.DataTokens = new RouteValueDictionary();
                        }
                        route.DataTokens["Namespaces"] = new string[] { item.Namespace };

                    }

                    routes.Add(item.Name, route);
                }
            }
        }

    }

}