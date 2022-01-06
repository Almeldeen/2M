using AutoMapper;
using DAL.Contanier;
using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Reposatiories.AttendRepo
{
    public class AttendRepo : IAttendRepo
    {
        private readonly ApplacationDbContext db;
        private readonly IMapper mapper;

        public AttendRepo(ApplacationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public int AddAttend(AttendVM Attend)
        {
            try
            {
                var data = mapper.Map<Attendance>(Attend);
                var att = db.Attendances.Where(x => x.EmpId == data.EmpId && x.Date == data.Date).FirstOrDefault();
                if (att==null)
                {
                    db.Attendances.Add(data);
                    int res = db.SaveChanges();
                    if (res > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 2;
                }
                
            }
            catch (Exception ex)
            {

                return 0;

            }
        }

        public IQueryable<AttendDetailsVM> GetAllAttend(DateTime date)
        {
            var data = db.Employees.Select(x => new AttendDetailsVM
            {
                EmpId = x.EmpId,
                EmpName = x.EmpName,
                JopName = x.Jop.JopName,
                Attends = db.Attendances.Where(a => a.EmpId == x.EmpId&&a.Absent==false).Count(),
                AttendReg= db.Attendances.Where(a => a.EmpId == x.EmpId && a.Date == date).Any()
            });
            return data;
        }

        public IQueryable<AttendVM> GetAttendById(int Id,DateTime start,DateTime end)
        {
            var data = db.Attendances.Where(x => x.EmpId == Id && (x.Date >= start && x.Date <= end)).Select(x => new AttendVM { EmpName = x.Employee.EmpName, Date = x.Date, Absent = x.Absent, Deduction = x.Deduction,Salary=x.Employee.OrgSalary });
            return data;
        }
    }
}
