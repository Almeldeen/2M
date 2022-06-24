using AutoMapper;
using DAL.Container;
using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Reprositry
{
    public class CategorieRepo : ICategorieRepo
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;

        public CategorieRepo(ApplicationDbContext db , IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public bool AddCategorie(CategorieVM categorie)
        {
            try
            {
                var data = mapper.Map<Categorie>(categorie);
                db.Categorie.Add(data);
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

        public bool EditCategorie(CategorieVM categorie)
        {
            try
            {
                var data = mapper.Map<Categorie>(categorie);
                db.Entry(data).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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

        public IQueryable<CategorieVM> GetAllCategorie()
        {
            var data = db.Categorie.Select(a => new CategorieVM { Id = a.Id, Name = a.Name });
            return data;
        }

        public CategorieVM GetByIdCategorie(int Id)
        {
            var data = db.Categorie.Where(a => a.Id == Id  ).Select(a => new CategorieVM { Id = a.Id, Name = a.Name }).FirstOrDefault();
            return data;
        }
    }
}
