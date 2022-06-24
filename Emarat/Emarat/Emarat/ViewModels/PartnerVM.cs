using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emarat.ViewModels
{
    public class PartnerVM
    {
        public int Id { get; set; }
        public string NameAn { get; set; }
        public string NameEr { get; set; }
        public string Logo { get; set; }
        public IFormFile LogoVM { get; set; }
    }
}
