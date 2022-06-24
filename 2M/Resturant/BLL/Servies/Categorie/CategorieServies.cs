using DAL.Reprositry;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Servies.Categorie
{
    public class CategorieServies : ICategorieServies
    {
        private readonly ICategorieRepo repo;

        public CategorieServies(ICategorieRepo repo )
        {
            this.repo = repo;
        }
        public bool AddCategorie(CategorieVM categorie)
        {
            return repo.AddCategorie(categorie);
        }

        public bool EditCategorie(CategorieVM categorie)
        {
            return repo.EditCategorie(categorie);
        }

        public IQueryable<CategorieVM> GetAllCategorie()
        {
            return repo.GetAllCategorie();
        }

        public CategorieVM GetByIdCategorie(int Id)
        {
            return repo.GetByIdCategorie(Id);
        }
    }
}
