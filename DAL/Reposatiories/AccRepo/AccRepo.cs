using AutoMapper;
using DAL.Contanier;
using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Reposatiories.AccRepo
{
    public class AccRepo : IAccRepo
    {
        private readonly ApplacationDbContext db;
        private readonly IMapper Mapper;

        public AccRepo( ApplacationDbContext db , IMapper Mapper )
        {
            this.db = db;
            this.Mapper = Mapper;
        }
        public bool AddAccount(AccVM Acc)
        {
            try
            {
                var data = Mapper.Map<Accounts>(Acc);
                db.Accounts.Add(data);
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

        public bool DeleteAccount(int Id)
        {
            try
            {
                var data = db.Accounts.Find(Id);
                db.Accounts.Remove(data);
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
            catch (Exception)
            {

                return false;

            }

        }

        public bool EditAccount(AccVM Acc)
        {
            try
            {
                var data = Mapper.Map<Accounts>(Acc);
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

        public AccVM GetAccountById(int Id)
        {
            var data = db.Accounts.Where(a => a.AccountId == Id).Select(a => new AccVM { AccountId = a.AccountId, Name = a.Name, Value = a.Value }).FirstOrDefault();
            return data;
        }

        public IQueryable<AccVM> GetAllAccount()
        {
            var data = db.Accounts.Select(a => new AccVM { AccountId = a.AccountId, Name = a.Name, Value = a.Value });
            return data;
        }
    }
}
