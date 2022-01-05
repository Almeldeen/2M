using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
  public  class AttendVM
    {
        public int AttId { get; set; }
        public DateTime Date { get; set; }
        public string DateStr { get; set; }
        public bool Absent { get; set; }
        public decimal Deduction { get; set; }
       
        public int EmpId { get; set; }
        public string EmpName{ get; set; }
        public int AbcentNum { get; set; }
        
    }
}
