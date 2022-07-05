using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P225Allup.Controllers
{
    public class AboutController : Controller
    {
        [Authorize(Roles = "SuperAdmin,Member")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
