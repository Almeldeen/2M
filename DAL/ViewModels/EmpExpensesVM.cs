using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class EmpExpensesVM
    {
        public int ExpenId { get; set; }
        public byte ExpensesType { get; set; }
        public decimal Value { get; set; }
        public string Note { get; set; }
        public DateTime Date { get; set; }
      
        public int EmpId { get; set; }
        public string EmpName { get; set; }
    }
}
