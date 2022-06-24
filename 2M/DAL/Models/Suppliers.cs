using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Suppliers
    {
        [Key]
        public int SuppId { get; set; }
        public string SuppName { get; set; }
        public virtual List<SupplierOperations> SupplierOperations { get; set; }
    }
}
