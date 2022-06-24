using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Reprositry.Item
{
   public  interface IItemRepo
    {
        bool AddItem(ItemVM item);
        bool EditItem(ItemVM item);
        IQueryable<ItemVM> GetAllItem();
        ItemVM GetByIdItem(int Id);

    }
}
