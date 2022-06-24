using AutoMapper;
using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapper
{
   public  class DominProfiles : Profile
    {
        public DominProfiles()
        {
            CreateMap<User, UserVM>();
            CreateMap<UserVM, User>();
            CreateMap<Categorie, CategorieVM>();
            CreateMap<CategorieVM, Categorie>();
            CreateMap<ItemVM, Item>();
            CreateMap<Item, ItemVM>();
            



        }
    }
}
