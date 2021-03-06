﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HuiWen.User.Controllers
{
    public class AccountController : BaseLoginController
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

        public JsonResult LoginUser()
        {
            return Json(new { }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult RegUser()
        {
            return Json(new { }, JsonRequestBehavior.AllowGet);
        }
    }
}