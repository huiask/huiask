using HuiWen.Tool.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HuiWen.User.Controllers
{
    public class HomeController : BaseUserLoginInfo
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
	}
}