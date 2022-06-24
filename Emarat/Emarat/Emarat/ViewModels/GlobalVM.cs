using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emarat.ViewModels
{
    public class GlobalVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageEn { get; set; }
        public IFormFile ImageEnVM { get; set; }
        public string ImageAr { get; set; }
        public IFormFile ImageArvM { get; set; }
        public string TitelEn { get; set; }
        public string TitelAr { get; set; }
        public string DetailsEn { get; set; }
        public string DetailsAr { get; set; }
    }
}
