using DAL.Reposatiories.SupplierRepo;
using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.SupplierServies
{
   public class SupplierServies:ISupplierServies
    {
        private readonly ISupplierRepo repo;

        public SupplierServies(ISupplierRepo repo)
        {
            this.repo = repo;
        }
        #region Sup
        public bool AddSupplier(SupplierVM Supplier)
        {
            return repo.AddSupplier(Supplier);
        }

        public bool DeleteSupplier(int Id)
        {
            return repo.DeleteSupplier(Id);
        }

        public bool EditSupplier(SupplierVM Supplier)
        {
            return repo.EditSupplier(Supplier);
        }

        public IQueryable<SupplierVM> GetAllSupplier()
        {
            return repo.GetAllSupplier();
        }

        public SupplierVM GetSupplierById(int Id)
        {
            return repo.GetSupplierById(Id);
        }
        #endregion
        #region SupOp
        public bool AddSupplierOp(SupOpVM SupOp)
        {
            return repo.AddSupplierOp(SupOp);
        }

        public bool DeleteSupplierOp(int Id)
        {
            return repo.DeleteSupplierOp(Id);
        }

        public bool EditSupplierOp(SupOpVM SupOp)
        {
            return repo.EditSupplierOp(SupOp);
        }

        public IQueryable<SupOpVM> GetAllSupplierOp()
        {
            return repo.GetAllSupplierOp();
        }

        public SupOpVM GetSupplierOpById(int Id)
        {
            return repo.GetSupplierOpById(Id);
        }
        #endregion
    }
}
