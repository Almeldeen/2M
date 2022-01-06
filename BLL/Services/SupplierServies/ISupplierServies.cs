using DAL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.SupplierServies
{
    public interface ISupplierServies
    {
        #region Sup
        bool AddSupplier(SupplierVM Supplier);
        bool EditSupplier(SupplierVM Supplier);
        bool DeleteSupplier(int Id);
        SupplierVM GetSupplierById(int Id);
        IQueryable<SupplierVM> GetAllSupplier();
        #endregion
        #region SupOp
        bool AddSupplierOp(SupOpVM Supplier);
        bool EditSupplierOp(SupOpVM Supplier);
        bool DeleteSupplierOp(int Id);
        SupOpVM GetSupplierOpById(int Id);
        IQueryable<SupOpVM> GetAllSupplierOp();
        #endregion
    }
}
