using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Reposatiories.AccRepo
{
    public interface IAccRepo
    {
        bool AddAccount(ِAccVM Acc);
        bool EditAccount(AccVM Acc);
        bool DeleteAccount(int Id);
        AccVM GetAccountById(int Id);
        IQueryable<AccVM> GetAllAccount();
    }
}
