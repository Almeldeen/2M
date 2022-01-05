using DAL.Reposatiories.AttendRepo;
using DAL.Reposatiories.EmpRepo;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.AttendServies
{
    public class AttendServies : IAttendServies
    {
        private readonly IAttendRepo repo;
        private readonly IEmpRepo Emprepo;

        public AttendServies(IAttendRepo repo,IEmpRepo Emprepo)
        {
            this.repo = repo;
            this.Emprepo = Emprepo;
        }
        public int AddAttend(AttendVM attend)
        {
            if (attend.AbcentNum>4)
            {
                var Emp = Emprepo.GetEmpById(attend.EmpId);
                attend.Deduction = Emp.OrgSalary-(Emp.OrgSalary - ((Emp.OrgSalary / 30) * attend.Deduction));
            }
            return repo.AddAttend(attend);
        }

        public IQueryable<AttendDetailsVM> GetAllAttend(DateTime date)
        {
            return repo.GetAllAttend(date);
        }

        public AttendVM GetAttendById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
