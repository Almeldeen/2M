using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Reposatiories.AttendRepo
{
    public interface IAttendRepo
    {
        bool AddAttend(AttendVM Emp);
       
        AttendVM GetAttendById(int Id);
        IQueryable<AttendDetailsVM> GetAllAttend();
    }
}
