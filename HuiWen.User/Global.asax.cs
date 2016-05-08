//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using System.Web.Routing;

//namespace HuiWen.User
//{
//    public class MvcApplication : System.Web.HttpApplication
//    {
//        protected void Application_Start()
//        {
//            AreaRegistration.RegisterAllAreas();
//            RouteConfig.RegisterRoutes(RouteTable.Routes);
//        }
//    }
//}
using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Mvc;
using System.Web.Routing;
using HuiWen.User;

namespace HuiWen.UserWeb
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = this.Server.GetLastError().GetBaseException();
            if (ex.GetType() == typeof(HttpException))
            {
                int i = ((HttpException)ex).GetHttpCode();
                if (i == 404)
                {
                    //配置中处理
                    //跳转到错误页面
                    //Response.Redirect("~/error.htm", false);
                    return;
                }
                if (i >= 500)
                {
                    var url = HttpContext.Current.Request.Url.ToString();
                    //Utilities.LogUtility.Error("地址：" + url, ex);
                }
            }
            else
            {
                //Utilities.LogUtility.Error("错误", ex);
            }
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}