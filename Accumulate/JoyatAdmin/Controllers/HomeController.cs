﻿using IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JoyatAdmin.Controllers
{
    public class HomeController : Controller
    {
        private IMenuBLL MenuBLL;
        public HomeController(IMenuBLL menubll)
        {
            MenuBLL = menubll;
        }
        public ActionResult Index()
        {
            var list = MenuBLL.GetMenus();
            return View(list);
        }

    }
}
