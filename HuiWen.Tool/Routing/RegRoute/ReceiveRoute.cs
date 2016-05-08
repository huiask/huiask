
namespace HuiTu.Utilities.Configuration.Routing.RegRoute
{
    public static class ReceiveRoute
    {
        public static string GetRouteKey(string key)
        {
            RouteMappingConfiguration config = RouteMappingConfiguration.Current;
            if (config == null)
            {
                return "";
            }
            foreach (RouteElement item in config.Routes)
            {
                if (item != null)
                {
                    if (item.Name == key)
                        return item.Url;
                }
            }
            return "";
        }
    }

}
