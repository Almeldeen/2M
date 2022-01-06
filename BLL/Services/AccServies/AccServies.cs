using DAL.Reposatiories.AccRepo;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.AccServies
{
    public class AccServies : IAccServies
    {
        private readonly IAccRepo repo;

        public AccServies(IAccRepo repo)
        {
            this.repo = repo;
        }
        #region Acc
        public bool AddAccount(AccVM Acc)
        {
            return repo.AddAccount(Acc);
        }

        public bool DeleteAccount(int Id)
        {
            return repo.DeleteAccount(Id);
        }

        public bool EditAccount(AccVM Acc)
        {
            return repo.EditAccount(Acc);
        }

        public IQueryable<AccVM> GetAllAccount()
        {
            return repo.GetAllAccount();
        }

        public AccVM GetAccountById(int Id)
        {
            return repo.GetAccountById(Id);
        }
        #endregion
        #region AccOp
        public bool AddAccountOp(AccOpVM AccOp)
        {
            return repo.AddAccountOp(AccOp);

        }

        public bool DeleteAccountOp(int Id)
        {
            return repo.DeleteAccountOp(Id);

        }

        public bool EditAccountOp(AccOpVM AccOp)
        {
            return repo.EditAccountOp(AccOp);

        }

        public AccOpVM GetAccountOpById(int Id)
        {
            return repo.GetAccountOpById(Id);
        }

        public IQueryable<AccOpVM> GetAllAccountOp()
        {
            return repo.GetAllAccountOp();
        }
        public IQueryable<AccOpVM> GetAccountOpCalById(int Id, DateTime start, DateTime end)
        {
            return repo.GetAccountOpCalById(Id, start, end);
        }
        #endregion

    }
}
