using BLL.Services.EmpExpensesService;
using DAL.Reposatiories.EmpExpensesRepo;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.EmpExpensesServices
{
    public class EmpExpensesServices : IEmpExpensesServies
    {
        private readonly IEmpExpensesRepo repo;

        public EmpExpensesServices(IEmpExpensesRepo repo)
        {
            this.repo = repo;
        }
        public bool AddEmpExpenses(EmpExpensesVM EmpExpenses)
        {
            return repo.AddEmpExpenses(EmpExpenses);
        }

        public bool DeleteEmpExpenses(int Id)
        {
            return repo.DeleteEmpExpenses(Id);
        }

        public bool EditEmpExpenses(EmpExpensesVM EmpExpenses)
        {
            return repo.EditEmpExpenses(EmpExpenses);
        }

        public IQueryable<EmpExpensesVM> GetAllEmpExpenses()
        {
            return repo.GetAllEmpExpenses();
        }

        public EmpExpensesVM GetEmpExpensesById(int Id)
        {
            return repo.GetEmpExpensesById(Id);
        }
    }
}
