using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Reprositry
{
    public interface ICategorieRepo
    {
        bool AddCategorie(CategorieVM categorie);
        bool EditCategorie(CategorieVM categorie);
        IQueryable<CategorieVM> GetAllCategorie();
        CategorieVM GetByIdCategorie(int Id);

    }
}
