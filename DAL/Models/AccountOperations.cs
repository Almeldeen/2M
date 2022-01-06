using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
  public class AccountOperations
    {
        [Key]
        public int Id { get; set; }
        public byte OpType { get; set; }
        public decimal OpValue { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
        [ForeignKey("Accounts")]
        public int AccountId { get; set; }
        public Accounts Accounts { get; set; }

    }
}
