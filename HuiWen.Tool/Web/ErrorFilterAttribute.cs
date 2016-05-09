using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HuiWen.Tool.Web
{
    public class ErrorFilterAttribute : ActionFilterAttribute, IExceptionFilter
    {
        /// <summary>
        /// 异常处理
        /// </summary>
        /// <param name="filterContext"></param>
        public void OnException(ExceptionContext filterContext)
        {
            //记录异常日志
            var context = HttpContext.Current;
            string url = string.Empty;
            if (context != null)
            {
                url = context.Request.Url.AbsoluteUri;
            }
            //LogUtility.Error(filterContext.Exception.Message + "IP:" + HTRequest.GetIP() + "，地址：" + url, filterContext.Exception);
        }
    }
}
