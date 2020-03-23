using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VNGraphiteCore.Models
{
    public class NewsModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Slug { get; set; }
        public decimal ViewCount { get; set; }
        public string ShortcutImage { get; set; }
        public string CreatedDate { get; set; }
        public string PublishDate { get; set; }
        public List<ImageModels> Images { get; set; }
        public List<TextBlockModel> TextBlocks { get; set; }
    }
}
