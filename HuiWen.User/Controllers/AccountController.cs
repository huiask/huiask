﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HuiWen.User.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Login/
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Reg()
        {
            return View();
        }
	}
}