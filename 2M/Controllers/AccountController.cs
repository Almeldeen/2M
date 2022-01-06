using BLL.Helper;
using BLL.Services.AccServies;
using DAL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2M.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccServies servies;

        public AccountController(IAccServies servies)
        {
            this.servies = servies;
        }
        #region Account
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddAccount(AccVM Acc)
        {
            var res = servies.AddAccount(Acc);
            return Json(res);
        }
        public IActionResult EditAccount(AccVM Acc)
        {
            var res = servies.EditAccount(Acc);
            return Json(res);
        }
        public IActionResult DeleteAccount(int Id)
        {
            var res = servies.DeleteAccount(Id);
            return Json(res);
        }
        public IActionResult GetAllAccount(int pageNumber = 1, int pageSize = 10)
        {
            var res = servies.GetAllAccount().ToList();

            var pagedData = Pagination.PagedResult(res, pageNumber, pageSize);
            return Json(pagedData);
        }
        public IActionResult GetAccountById(int Id)
        {
            var res = servies.GetAccountById(Id);
            return Json(res);
        }
        #endregion
        #region AccountOp
        public IActionResult AccountOperation()
        {
            ViewBag.Acc = servies.GetAllAccount();
            return View();
        }
        public IActionResult ViewAccountOperation()
        {
            ViewBag.Acc = servies.GetAllAccount();
            return View();
        }
        public IActionResult AddAccountOp(AccOpVM AccOp)
        {
            var res = servies.AddAccountOp(AccOp);
            return Json(res);
        }
        public IActionResult EditAccountOp(AccOpVM AccOp)
        {
            var res = servies.EditAccountOp(AccOp);
            return Json(res);
        }
        public IActionResult DeleteAccountOp(int Id)
        {
            var res = servies.DeleteAccountOp(Id);
            return Json(res);
        }
        public IActionResult GetAllAccountOp(int pageNumber = 1, int pageSize = 10)
        {
            var res = servies.GetAllAccountOp().ToList();

            var pagedData = Pagination.PagedResult(res, pageNumber, pageSize);
            return Json(pagedData);
        }
        public IActionResult GetAccountOpById(int Id)
        {
            var res = servies.GetAccountOpById(Id);
            return Json(res);
        }
        public IActionResult GetAccountOpCalById(int Id, DateTime start, DateTime end)
        {
            var res = servies.GetAccountOpCalById(Id , start , end);
            return Json(res);
        }
        #endregion
    }
}
