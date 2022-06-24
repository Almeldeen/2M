using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Servies.Categorie
{
    public interface ICategorieServies
    {
        bool AddCategorie(CategorieVM categorie);
        bool EditCategorie(CategorieVM categorie);
        IQueryable<CategorieVM> GetAllCategorie();
        CategorieVM GetByIdCategorie(int Id);
    }
}
