﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VNGraphiteCore.Controllers
{
    [Route("hinh-anh")]
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}