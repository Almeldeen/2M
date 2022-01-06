using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SupplierOperations
    {
        [Key]
        public int OpeId { get; set; }
        public decimal TotalValue { get; set; }
        public decimal Payment { get; set; }
        public decimal TheRest { get; set; }
        public string Note { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("Suppliers")]
        public int SuppId { get; set; }
        public Suppliers Suppliers { get; set; }

    }
}
