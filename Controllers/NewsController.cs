using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VNGraphiteCore.Controllers
{
    [Route("tin-tuc")]
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/tin-tuc/chi-tiet/{id?}")]
        public IActionResult Detail(int id = 1)
        {
            return View();
        }
    }
}