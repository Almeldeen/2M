using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
   public class EmpVM
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal OrgSalary { get; set; }
        public decimal TotalSalary { get; set; }
       
        public int JopId { get; set; }
        public string JopName { get; set; }

    }
}
