using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Reposatiories.EmpExpensesRepo
{
    public interface IEmpExpensesRepo
    {
        bool AddEmpExpenses(EmpExpensesVM EmpExpenses);
        bool EditEmpExpenses(EmpExpensesVM EmpExpenses);
        bool DeleteEmpExpenses(int Id);
        EmpExpensesVM GetEmpExpensesById(int Id);
        IQueryable<EmpExpensesVM> GetAllEmpExpenses();
    }
}
