using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Emarat.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string Image { get; set; }
        public List<ServiceDetails> ServiceDetails { get; set; }
    }
}
