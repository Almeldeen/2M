using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class EmpExpenses
    {
        [Key]
        public int ExpenId { get; set; }
        public byte ExpensesType { get; set; }
        public decimal Value { get; set; }
        public string Note { get; set; }
        [ForeignKey("Employee")]
        public int EmpId { get; set; }
        public Employee Employee { get; set; }
    }
}
