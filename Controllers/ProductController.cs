using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VNGraphiteCore.Controllers
{
    [Route("san-pham")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}