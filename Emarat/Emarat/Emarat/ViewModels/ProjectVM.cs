using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emarat.ViewModels
{
    public class ProjectVM
    {
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string DetailsEn { get; set; }
        public string DetailsAr { get; set; }
        public DateTime DateEn { get; set; }
        public DateTime DateAr { get; set; }
        public string LocationEn { get; set; }
        public string LocationAr { get; set; }
       
        public int ServiceDetailsID { get; set; }
        
        public List<IFormFile> ProjectImage { get; set; }
        public List<string> ProjectImagePath { get; set; }
    }
}
