using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class SupOpVM
    {
        public int OpeId { get; set; }
        public decimal TotalValue { get; set; }
        public decimal Payment { get; set; }
        public byte OpType { get; set; }

        public decimal theRest { get; set; }
        public DateTime Date { get; set; }
        
        public int SuppId { get; set; }
        public string SuppName { get; set; }
    }
}
