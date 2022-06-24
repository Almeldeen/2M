using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emarat.ViewModels
{
    public class ServiceVM
    {
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string Image { get; set; }
        public IFormFile ImageVM { get; set; }
        
    }
}
