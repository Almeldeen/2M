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
        bool AddSupplier(SupplierVM Supplier);
        bool EditSupplier(SupplierVM Supplier);
        bool DeleteSupplier(int Id);
        SupplierVM GetSupplierById(int Id);
        IQueryable<SupplierVM> GetAllSupplier();
    }
}
