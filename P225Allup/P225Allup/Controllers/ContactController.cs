using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P225Allup.Controllers
{
    [Authorize(Roles = "SuperAdmin,Member")]
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
