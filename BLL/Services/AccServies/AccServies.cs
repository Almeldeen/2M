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
    }
}
