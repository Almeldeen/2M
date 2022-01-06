using BLL.Helper;
using BLL.Services.SupplierServies;
using DAL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2M.Controllers
{
    public class SupplierController : Controller
    {
       
        private readonly ISupplierServies service;

        public SupplierController(ISupplierServies service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
        #region Sup

        public IActionResult AddSupplier(SupplierVM Supplier)
        {
            var res = service.AddSupplier(Supplier);
            return Json(res);
        }
        public IActionResult EditSupplier(SupplierVM Supplier)
        {
            var res = service.EditSupplier(Supplier);
            return Json(res);
        }
        public IActionResult DeleteSupplier(int Id)
        {
            var res = service.DeleteSupplier(Id);
            return Json(res);
        }
        public IActionResult GetAllSupplier(int pageNumber = 1, int pageSize = 10)
        {
            var res = service.GetAllSupplier().ToList();

            var pagedData = Pagination.PagedResult(res, pageNumber, pageSize);
            return Json(pagedData);
        }
        public IActionResult GetSupplierById(int Id)
        {
            var res = service.GetSupplierById(Id);
            return Json(res);
        }
        #endregion
        #region SupOp
        public IActionResult SupplierOperation()
        {
            ViewBag.Sup = service.GetAllSupplier();
            return View();
        }
        public IActionResult ViewSupplierOperation()
        {
            ViewBag.Sup = service.GetAllSupplier();
            return View();
        }
        public IActionResult AddSupplierOp(SupOpVM SupOp)
        {
            var res = service.AddSupplierOp(SupOp);
            return Json(res);
        }
        public IActionResult EditSupplierOp(SupOpVM SupOp)
        {
            var res = service.EditSupplierOp(SupOp);
            return Json(res);
        }
        public IActionResult DeleteSupplierOp(int Id)
        {
            var res = service.DeleteSupplierOp(Id);
            return Json(res);
        }
        public IActionResult GetAllSupplierOp(int pageNumber = 1, int pageSize = 10)
        {
            var res = service.GetAllSupplierOp().ToList();

            var pagedData = Pagination.PagedResult(res, pageNumber, pageSize);
            return Json(pagedData);
        }
        public IActionResult GetSupplierOpById(int Id)
        {
            var res = service.GetSupplierOpById(Id);
            return Json(res);
        }
        #endregion
    }
}
