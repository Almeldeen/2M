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
        public bool AddAttend(AttendVM Attend)
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
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception ex)
            {

                return false;

            }
        }

        public IQueryable<AttendDetailsVM> GetAllAttend()
        {
            var data = db.Employees.Select(x => new AttendDetailsVM
            {
                EmpId = x.EmpId,
                EmpName = x.EmpName,
                JopName = x.Jop.JopName,
                Attends = db.Attendances.Where(a => a.EmpId == x.EmpId&&a.Absent==false).Count()
            });
            return data;
        }

        public AttendVM GetAttendById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
