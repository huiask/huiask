using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HuiWen.Tool.Web
{
    [ErrorFilter]
    [AuthorizeFilter]
    public class BaseUserInfo : Controller
    {
        //前端调用 @ViewBag.BaseUser 获取相关会员信息
        //Action使用[AllowAnonymous]跳过[AuthorizeFilter]验证
    }

    [ErrorFilter]
    public class BaseUserLoginInfo : Controller
    {
        //前端调用 @ViewBag.BaseUser 获取相关会员信息
        //Action使用[AllowAnonymous]跳过[AuthorizeFilter]验证
    }
}
