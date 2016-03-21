﻿
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;

namespace idunno.Authentication.Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Policy = "AlwaysFail")]
        public IActionResult AlwaysFail()
        {
            return View();
        }
    }
}