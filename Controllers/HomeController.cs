using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netdocs_api.Models;

namespace netdocs_api.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
