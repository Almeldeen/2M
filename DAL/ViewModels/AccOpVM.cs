using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class AccOpVM
    {
        public int Id { get; set; }
        public byte OpType { get; set; }
        public decimal OpValue { get; set; }
        public DateTime Date { get; set; }
       
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public string AccountValue { get; set; }
        public string Note { get; set; }
        
    }
}
