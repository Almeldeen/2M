using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
   public class AttendDetailsVM
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string JopName { get; set; }
        public int Attends { get; set; }
        public bool AttendReg { get; set; }
    }
}
