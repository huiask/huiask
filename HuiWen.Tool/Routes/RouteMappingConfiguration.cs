using System.Configuration;

namespace Routes.Routing
{
    /// <summary>
    /// 
    /// </summary>
    public class RouteMappingConfiguration : ConfigurationSection
    {
        public static RouteMappingConfiguration Current
        {
            get
            {
                return (RouteMappingConfiguration)ConfigurationManager.GetSection("routeMapping");
            }
        }

        [ConfigurationProperty("routes", IsRequired = true)]
        public RouteElementCollection Routes
        {
            get
            {
                return (RouteElementCollection)this["routes"];
            }
            set
            {
                this["routes"] = value;
            }
        }

        [ConfigurationProperty("ignoreRoutes", IsRequired = true)]
        public RouteElementCollection IgnoreRoutes
        {
            get
            {
                return (RouteElementCollection)this["ignoreRoutes"];
            }
            set
            {
                this["ignoreRoutes"] = value;
            }
        }
    }
}
