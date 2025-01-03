﻿using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace PortfolioProject.Controllers
{
   
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.active = "Dashboard";
            return View();
        }

        //public PartialViewResult ScriptPartial() {
        //    return PartialView();
        //}
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult SideNavbarPartial() { 
            return PartialView();
        }

      
        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }
    }
}
