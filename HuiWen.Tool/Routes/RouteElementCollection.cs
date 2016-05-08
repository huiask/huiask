using System.Configuration;

namespace Routes.Routing
{
    public class RouteElementCollection : ConfigurationElementCollection
    {

        [ConfigurationProperty("routeExistingFiles", DefaultValue = null)]
        public bool? RouteExistingFiles
        {
            get
            {
                return (bool?)this["routeExistingFiles"];
            }
            set
            {
                this["routeExistingFiles"] = value;
            }
        }

        [ConfigurationProperty("lowerCaseOnly")]
        public bool LowerCaseOnly
        {
            get
            {
                return (bool)this["lowerCaseOnly"];
            }
            set
            {
                this["lowerCaseOnly"] = value;
            }
        }

        public void Add(RouteElement element)
        {
            BaseAdd(element);
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new RouteElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((RouteElement)(element)).Name;
        }

        public RouteElement this[int index]
        {
            get
            {
                return (RouteElement)BaseGet(index);
            }
        }

    }

}
