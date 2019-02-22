using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netdocs_api.Models;

namespace netdocs_api.Controllers
{
    [Route("NetDocs")]
    public class NetDocsController : Controller
    {
        [Route("Return")]
        public IActionResult Return([FromQuery]string access_token)
        {
            return RedirectToAction("Index");
        }
        
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}