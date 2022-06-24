using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Accounts
    {
        [Key]
        public int AccountId { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public virtual List<AccountOperations> AccountOperations { get; set; }
    }
}
