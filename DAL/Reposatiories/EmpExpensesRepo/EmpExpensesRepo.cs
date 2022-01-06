using AutoMapper;
using DAL.Contanier;
using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Reposatiories.EmpExpensesRepo
{
    public class EmpExpensesRepo : IEmpExpensesRepo
    {
        private readonly ApplacationDbContext db;
        private readonly IMapper mapper;

        public EmpExpensesRepo(ApplacationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }


        public bool AddEmpExpenses(EmpExpensesVM EmpExpenses)
        {
            try
            {
                var data = mapper.Map<EmpExpenses>(EmpExpenses);

                db.EmpExpenses.Add(data);
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



        public bool DeleteEmpExpenses(int Id)
        {
            try
            {
                var data = db.EmpExpenses.Find(Id);
                db.EmpExpenses.Remove(data);
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

        public bool EditEmpExpenses(EmpExpensesVM EmpExpenses)
        {
            try
            {
                var data = mapper.Map<EmpExpenses>(EmpExpenses);
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

        public IQueryable<EmpExpensesVM> GetAllEmpExpenses()
        {
            var data = db.EmpExpenses.Select(a => new EmpExpensesVM { EmpId =a.EmpId,EmpName=a.Employee.EmpName ,ExpenId=a.ExpenId,ExpensesType=a.ExpensesType,Note=a.Note,Value=a.Value });

            return data;
        }

        public EmpExpensesVM GetEmpExpensesById(int Id)
        {
            var data = db.EmpExpenses.Where(a => a.ExpenId == Id).Select(a => new EmpExpensesVM { EmpId = a.EmpId, EmpName = a.Employee.EmpName, ExpenId = a.ExpenId, ExpensesType = a.ExpensesType, Note = a.Note, Value = a.Value }).FirstOrDefault();
            return data;
        }
    }
}
