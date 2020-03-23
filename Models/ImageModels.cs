using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VNGraphiteCore.Models
{
    public class ImageModels
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public string ShortDescription { get; set; }
        public int Position { get; set; }
        public int TextBlockId { get; set; }
    }
}
