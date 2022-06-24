using AutoMapper;
using DAL.Contanier;
using DAL.Models;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Reposatiories.SupplierRepo
{
   public class SupplierRepo :ISupplierRepo
    {
        private readonly ApplacationDbContext db;
        private readonly IMapper mapper;

        public SupplierRepo(ApplacationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        #region Sup
        public bool AddSupplier(SupplierVM Supplier)
        {
            try
            {
                var data = mapper.Map<Suppliers>(Supplier);
                db.Suppliers.Add(data);
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



        public bool DeleteSupplier(int Id)
        {
            try
            {
                var data = db.Suppliers.Find(Id);
                db.Suppliers.Remove(data);
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

        public bool EditSupplier(SupplierVM Supplier)
        {
            try
            {
                var data = mapper.Map<Suppliers>(Supplier);
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

        public IQueryable<SupplierVM> GetAllSupplier()
        {
            var data = db.Suppliers.Select(a => new SupplierVM { SuppId = a.SuppId, SuppName = a.SuppName });
            return data;
        }

        public SupplierVM GetSupplierById(int Id)
        {
            var data = db.Suppliers.Where(a => a.SuppId == Id).Select(a => new SupplierVM { SuppId = a.SuppId, SuppName = a.SuppName }).FirstOrDefault();
            return data;
        }
        #endregion
        #region SupOp
        public bool AddSupplierOp(SupOpVM SupOp)
        {
            try
            {
                var data = mapper.Map<SupplierOperations>(SupOp);
                db.SupplierOperations.Add(data);
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



        public bool DeleteSupplierOp(int Id)
        {
            try
            {
                var data = db.SupplierOperations.Find(Id);
                db.SupplierOperations.Remove(data);
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

        public bool EditSupplierOp(SupOpVM SupOp)
        {
            try
            {
                var data = mapper.Map<SupplierOperations>(SupOp);
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

        public IQueryable<SupOpVM> GetAllSupplierOp()
        {
            var data = db.SupplierOperations.Select(a => new SupOpVM { OpeId=a.OpeId , SuppName=a.Suppliers.SuppName , Date=a.Date , Payment=a.Payment , SuppId=a.SuppId , TheRest=a.TheRest, TotalValue=a.TotalValue,Note=a.Note});
            return data;
        }

        public SupOpVM GetSupplierOpById(int Id)
        {
            var data = db.SupplierOperations.Where(a => a.OpeId == Id).Select(a => new SupOpVM { OpeId = a.OpeId, SuppName = a.Suppliers.SuppName, Date = a.Date, Payment = a.Payment, SuppId = a.SuppId, TheRest = a.TheRest, TotalValue = a.TotalValue,Note=a.Note }).FirstOrDefault();
            return data;
        }
#endregion
    }
}
