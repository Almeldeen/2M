using AutoMapper;
using DAL.Container;
using DAL.ViewModels;
using DAL.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Reprositry.Item
{
    public class ItemRepo : IItemRepo
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public ItemRepo(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public bool AddItem(ItemVM item)
        {
            try
            {
                var data = mapper.Map<DAL.Models.Item>(item);
                db.Item.Add(data);
                var res = db.SaveChanges();
                if (res > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                return false;

            }
        }

        public bool EditItem(ItemVM categorie)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ItemVM> GetAllItem()
        {
            throw new NotImplementedException();
        }

        public ItemVM GetByIdItem(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
