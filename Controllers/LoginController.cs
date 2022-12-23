using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace branding.Controllers
{
    public class LoginController : Controller
    {
        private readonly  ILogger<HomeController> _logger;

        public LoginController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult login()
        {
            return View();
        }
    }
}
    

        