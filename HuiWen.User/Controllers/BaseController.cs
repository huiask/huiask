using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HuiWen.User.Controllers
{
    public class BaseController : HuiWen.Tool.Web.BaseUserInfo
    {
        //
        // GET: /Base/
        public BaseController()
        {

        }
	}

    public class BaseLoginController : HuiWen.Tool.Web.BaseUserLoginInfo
    {
        public BaseLoginController()
        {

        }
    }
}