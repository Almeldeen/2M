using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Attendance
    {
        [Key]
        public int AttId { get; set; }
        public DateTime Date { get; set; }
        public bool Absent { get; set; }
        public decimal Deduction { get; set; }
        [ForeignKey("EmpId")]
        public int EmpId { get; set; }
        public Employee Employee { get; set; }
    }
}
