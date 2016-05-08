using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Routing;

namespace Routes.RegRoute
{
    public class StrictRoute : Route
    {
        public bool LowerCaseOnly
        {
            get;
            set;
        }

        public StrictRoute(string url, IRouteHandler handler)
            : base(url, handler)
        {

        }

        public StrictRoute(string url, IRouteHandler handler, bool lowerCaseOnly)
            : this(url, handler)
        {
            LowerCaseOnly = lowerCaseOnly;
        }



        public override RouteData GetRouteData(HttpContextBase httpContext)
        {
            RouteData data = base.GetRouteData(httpContext);
            if (data != null)
            {

                var virtualPath = httpContext.Request.AppRelativeCurrentExecutionFilePath.Substring(2) + httpContext.Request.PathInfo;

                if (virtualPath.Length > 1)
                {

                    if (Regex.Matches(this.Url, "/").Count != Regex.Matches(virtualPath, "/").Count)
                    {
                        data = null;
                    }
                    else if (LowerCaseOnly && virtualPath.ToLower() != virtualPath)
                    {
                        data = null;
                    }
                }
            }
            return data;
        }

        public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
        {
            #region Remove default values
            if (values.Count > 2 && this.Defaults.Count > 2 && values.ContainsKey("Controller") && values.ContainsKey("Action"))
            {

                if (this.Defaults["Controller"].ToString().ToUpper() == values["Controller"].ToString().ToUpper() && this.Defaults["Action"].ToString().ToUpper() == values["Action"].ToString().ToUpper())
                {

                    foreach (KeyValuePair<string, object> item in this.Defaults)
                    {
                        if (item.Key.ToUpper() != "CONTROLLER" && item.Key.ToUpper() != "ACTION")
                        {
                            if (values.ContainsKey(item.Key))
                            {
                                if (values[item.Key].ToString().ToUpper() == item.Value.ToString().ToUpper())
                                {

                                    values.Remove(item.Key);


                                    if (requestContext.RouteData.Values.ContainsKey(item.Key))
                                    {
                                        requestContext.RouteData.Values.Remove(item.Key);
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {

                    return null;
                }
            }
            #endregion

            VirtualPathData data = base.GetVirtualPath(requestContext, values);
            if (data != null)
            {
                if (Regex.Matches(data.VirtualPath, "/").Count < Regex.Matches(this.Url, "/").Count)
                {
                    if (!data.VirtualPath.Contains("?"))
                    {
                        data.VirtualPath += "/";
                    }
                    else
                    {
                        int position = data.VirtualPath.IndexOf("?");
                        data.VirtualPath = data.VirtualPath.Substring(0, position) + "/" + data.VirtualPath.Substring(position);
                    }
                }

                if (LowerCaseOnly)
                {
                    data.VirtualPath = data.VirtualPath.ToLower();
                }
            }

            return data;
        }
    }

}
