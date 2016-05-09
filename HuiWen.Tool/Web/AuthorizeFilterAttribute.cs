using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HuiWen.Tool.Web
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class AuthorizeFilterAttribute : ActionFilterAttribute
    {
        //public BaseUserEntity BaseUser;

        /// <summary>
        /// 在执行操作方法之前由 ASP.NET MVC 框架调用。
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if ((!filterContext.ActionDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true) && !filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true)))
            {
                //BaseUserEntity BaseUser = null;
                //int checkResult = Security.CheckUser(out BaseUser);

                //(filterContext.Controller as Controller).ViewBag.BaseUser = BaseUser;

                //if (checkResult != 1)
                //{
                //    Security.DeleteLoginCookies();//删除cookies
                //    Uri uri = HttpContext.Current.Request.Url;
                //    string backurl = string.Empty;
                //    if (uri != null && !string.IsNullOrEmpty(uri.AbsoluteUri))
                //    {
                //        backurl = Utility.CombineUrl(Sys.BCInfo.UserUrl, "op/login.aspx?backurl=") + Utility.UrlEncode(uri.AbsoluteUri);
                //    }

                //    if (checkResult == -1)
                //        filterContext.Result = new ContentResult { Content = @"<script>alert('您的账号可能已在别处登录，重新登录后查看登录日志，若有异常请及时更改密码。\n\r若需同时在多处登录改用[多人登录模式]');window.location.href='" + backurl + "';</script>" };
                //    else
                //        filterContext.Result = new RedirectResult(backurl);
                //}
                //else
                //{
                //    try
                //    {
                //        //查询是否有需要添加的数据
                //        int userId = Security.GetUserId();
                //        if (Messages.GetUserNewMessage(userId) > 0)
                //        {
                //            Messages.AddUserMessage(userId);
                //        }
                //    }
                //    catch (Exception ef)
                //    {
                //        LogUtility.Error(ef.Message, ef);
                //    }
                //}
            }
        }

        /// <summary>
        /// 在执行操作方法后由 ASP.NET MVC 框架调用。
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }

        /// <summary>
        ///  OnResultExecuted 在执行操作结果后由 ASP.NET MVC 框架调用。
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }

        /// <summary>
        /// OnResultExecuting 在执行操作结果之前由 ASP.NET MVC 框架调用。
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }
    }
}
