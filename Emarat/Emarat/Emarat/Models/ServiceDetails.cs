using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Emarat.Models
{
    public class ServiceDetails
    {
        [Key]
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        [ForeignKey("ServiceId")]
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public List<Project> Projects { get; set; }
    }
}
