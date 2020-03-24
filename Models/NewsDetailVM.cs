using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VNGraphiteCore.Models
{
    public class NewsDetailVM
    {
        public NewsModel NewsDetail { get; set; }
        public List<NewsModel> PopularNews { get; set; }
    }
}
