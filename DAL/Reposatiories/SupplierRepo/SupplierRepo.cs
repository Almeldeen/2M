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
    }
}
