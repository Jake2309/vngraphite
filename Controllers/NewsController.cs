using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VNGraphiteCore.Models;

namespace VNGraphiteCore.Controllers
{
    [Route("tin-tuc")]
    public class NewsController : Controller
    {
        private Random rnd = new Random();
        public IActionResult Index()
        {
            ViewData["Category"] = SampleData.CategoryData.ToDictionary(k => k.Id, v => v.CategoryName);

            var dictNewsData = SampleData.NewsData.GroupBy(x => x.CategoryID).ToDictionary(k => k.Key, v => v.ToList());

            return View(dictNewsData);
        }

        [Route("/tin-tuc/chi-tiet/{slug?}")]
        public IActionResult Detail(string slug = "")
        {
            if (String.IsNullOrEmpty(slug))
            {
                return View("Error");
            }
            var newsDetail = SampleData.NewsData.FirstOrDefault(x => x.Slug == slug);

            if (newsDetail == null)
            {
                return View("Error");
            }

            if(newsDetail.TextBlocks != null && newsDetail.TextBlocks.Any())
                newsDetail.TextBlocks = newsDetail.TextBlocks.OrderBy(x => x.Position).ToList();

            if (newsDetail.Images != null && newsDetail.Images.Any())
                newsDetail.Images = newsDetail.Images.OrderBy(x => x.Position).ToList();
            else
                newsDetail.Images = new List<ImageModels>();

            // Giả lập số lượng view
            foreach (var news in SampleData.NewsData)
            {
                news.ViewCount = rnd.Next(1, 100000);
            }

            var detailVM = new NewsDetailVM { 
                NewsDetail = newsDetail,
                PopularNews = SampleData.NewsData.OrderByDescending(x => x.ViewCount).Take(2).ToList()
            };

            return View(detailVM);
        }
    }
}