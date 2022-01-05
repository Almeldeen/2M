using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.AttendServies
{
    public interface IAttendServies
    {
        bool AddAttend(AttendVM Emp);

        AttendVM GetAttendById(int Id);
        IQueryable<AttendDetailsVM> GetAllAttend();
    }
}
