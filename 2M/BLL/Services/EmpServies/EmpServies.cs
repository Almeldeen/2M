using DAL.Reposatiories.EmpRepo;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.EmpServies
{
    public class EmpServies : IEmpServies
    {
        private readonly IEmpRepo repo;

        public EmpServies( IEmpRepo repo)
        {
            this.repo = repo;
        }
        public bool AddEmp(EmpVM Emp)
        {
            return repo.AddEmp(Emp);
        }

        public bool DeleteEmp(int Id)
        {
            return repo.DeleteEmp(Id);
        }

        public bool EditEmp(EmpVM Emp)
        {
            return repo.EditEmp(Emp);
        }

        public IQueryable<EmpVM> GetAllEmp()
        {
            return repo.GetAllEmp();
        }

        public EmpVM GetEmpById(int Id)
        {
            return repo.GetEmpById(Id);
        }
    }
}
