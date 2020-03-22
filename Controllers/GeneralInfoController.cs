using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VNGraphiteCore.Controllers
{
    [Route("thong-tin-chung")]
    public class GeneralInfoController : Controller
    {
        [Route("~/thong-tin-chung/{moduleName?}")]
        public IActionResult Index(string moduleName = "")
        {
            return View();
        }
    }
}