using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal OrgSalary { get; set; }
        public decimal TotalSalary{ get; set; }
        [ForeignKey("JopId")]
        public int JpoId { get; set; }
        public Jop Jop { get; set; }
        public virtual List<Attendance> Attendances { get; set; }
        public virtual List<EmpExpenses> EmpExpenses { get; set; }

    }
}
