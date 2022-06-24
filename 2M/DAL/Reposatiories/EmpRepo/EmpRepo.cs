using AutoMapper;
using DAL.Contanier;
using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Reposatiories.EmpRepo
{
   public class EmpRepo : IEmpRepo
    {
        private readonly ApplacationDbContext db;
        private readonly IMapper mapper;

        public EmpRepo(ApplacationDbContext db , IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        
        public bool AddEmp(EmpVM Emp)
        {
            try
            {
                var data = mapper.Map<Employee>(Emp);
              
                db.Employees.Add(data);
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
            catch (Exception ex)
            {

                return false;

            }


        }

      

        public bool DeleteEmp(int Id)
        {
            try
            {
                var data = db.Employees.Find(Id);
                db.Employees.Remove(data);
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
            catch (Exception ex)
            {

                return false;

            }

        }

        public bool EditEmp(EmpVM Emp)
        {
            try
            {
                var data = mapper.Map<Employee>(Emp);
                db.Entry(data).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
            catch (Exception ex)
            {

                    return false;

            }

        }

        public IQueryable<EmpVM> GetAllEmp()
        {
            var data = db.Employees.Select(a => new EmpVM { EmpId = a.EmpId, EmpName = a.EmpName, OrgSalary = a.OrgSalary, PhoneNumber = a.PhoneNumber, TotalSalary = a.TotalSalary, JopId = a.JopId, JopName = a.Jop.JopName });
            return data;
        }

        public EmpVM GetEmpById(int Id)
        {
            var data = db.Employees.Where(a => a.EmpId == Id).Select(a => new EmpVM { EmpId = a.EmpId, EmpName = a.EmpName, OrgSalary = a.OrgSalary, PhoneNumber = a.PhoneNumber, TotalSalary = a.TotalSalary, JopId = a.JopId, JopName = a.Jop.JopName }).FirstOrDefault();
            return data;
        }
    }
}
