using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitCheckProject.Controllers
{
    public class VistorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
