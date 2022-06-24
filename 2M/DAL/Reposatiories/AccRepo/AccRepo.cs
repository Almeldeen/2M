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
        #region Acc
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
        #endregion
        #region AccOp
        public bool AddAccountOp(AccOpVM AccOp)
        {
            try
            {
                var data = Mapper.Map<AccountOperations>(AccOp);
                db.AccountOperations.Add(data);
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

        public bool DeleteAccountOp(int Id)
        {
            try
            {
                var data = db.AccountOperations.Find(Id);
                db.AccountOperations.Remove(data);
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

        public bool EditAccountOp(AccOpVM AccOp)
        {
            try
            {
                var data = Mapper.Map<AccountOperations>(AccOp);
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

        public AccOpVM GetAccountOpById(int Id)
        {
            var data = db.AccountOperations.Where(a => a.Id == Id ).Select(a => new AccOpVM { Id =a.Id , AccountId=a.AccountId , AccountName=a.Accounts.Name  , OpType=a.OpType , OpValue=a.OpValue,Date=a.Date,Note=a.Note }).FirstOrDefault();

            return data;
        }

        public IQueryable<AccOpVM> GetAllAccountOp()
        {
            var data = db.AccountOperations.Select(a => new AccOpVM { Id = a.Id, AccountId = a.AccountId, AccountName = a.Accounts.Name, OpType = a.OpType, OpValue = a.OpValue, Date = a.Date,Note=a.Note });
            return data;
        }
        public IQueryable<AccOpVM> GetAccountOpCalById( int Id ,DateTime start ,DateTime end)
        {
            var data = db.AccountOperations.Where(a=>  a.AccountId == Id && (a.Date >=start && a.Date <= end)).Select(a => new AccOpVM { Id = a.Id, AccountId = a.AccountId, AccountName = a.Accounts.Name, OpType = a.OpType, OpValue = a.OpValue, Date = a.Date });
            return data;
        }
        #endregion 

    }
}
