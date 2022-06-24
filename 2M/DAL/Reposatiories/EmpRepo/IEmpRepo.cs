using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Reposatiories.EmpRepo
{
    public interface IEmpRepo
    {
        bool AddEmp(EmpVM Emp);
        bool EditEmp(EmpVM Emp);
        bool DeleteEmp(int Id);
        EmpVM GetEmpById(int Id);
        IQueryable<EmpVM> GetAllEmp();
    }
}
