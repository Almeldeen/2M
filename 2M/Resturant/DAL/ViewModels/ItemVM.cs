using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
   public class ItemVM
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public string Descrption { get; set; }
    }
}
