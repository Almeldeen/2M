using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.AccServies
{
    public interface IAccServies
    {
        #region Acc
        bool AddAccount(AccVM Acc);
        bool EditAccount(AccVM Acc);
        bool DeleteAccount(int Id);
        AccVM GetAccountById(int Id);
        IQueryable<AccVM> GetAllAccount();
        #endregion
        #region AccOp
        bool AddAccountOp(AccOpVM AccOp);
        bool EditAccountOp(AccOpVM AccOP);
        bool DeleteAccountOp(int Id);
        AccOpVM GetAccountOpById(int Id);
        IQueryable<AccOpVM> GetAllAccountOp();
        IQueryable<AccOpVM> GetAccountOpCalById(int Id, DateTime start, DateTime end);
        #endregion
    }
}
