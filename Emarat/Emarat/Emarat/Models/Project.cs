using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Emarat.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string DetailsEn { get; set; }
        public string DetailsAr { get; set; }
        public DateTime DateEn { get; set; }
        public DateTime DateAr { get; set; }
        public string LocationEn { get; set; }
        public string LocationAr { get; set; }
        [ForeignKey("ServiceId")]
        public int ServiceDetailsID { get; set; }
        public ServiceDetails serviceDetails { get; set; }
        public List<ProjectImages> ProjectImages { get; set; }
    }
}
