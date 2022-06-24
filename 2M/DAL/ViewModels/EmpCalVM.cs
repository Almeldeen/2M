using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class EmpCalVM
    {
        public int EmpCalId { get; set; }
        public string EmpName { get; set; }
        public DateTime Date { get; set; }
        public byte ExpensesType { get; set; }

        public decimal Empsalary { get; set; }
        public decimal EmpAbssalary { get; set; }
        public decimal Empvalue { get; set; }
       
       
    }
}
