using BLL.Helper;
using BLL.Services.EmpExpensesService;
using DAL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2M.Controllers
{
    public class EmpExpenseController : Controller
    {
        private IEmpExpensesServies servies;

        public EmpExpenseController(IEmpExpensesServies servies)
        {
            this.servies = servies;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddAccount(EmpExpensesVM EmpExpenses)
        {
            var res = servies.AddEmpExpenses(EmpExpenses);
            return Json(res);
        }
        public IActionResult EditEmpExpenses(EmpExpensesVM EmpExpenses)
        {
            var res = servies.EditEmpExpenses(EmpExpenses);
            return Json(res);
        }
        public IActionResult DeleteEmpExpenses(int Id)
        {
            var res = servies.DeleteEmpExpenses(Id);
            return Json(res);
        }
        public IActionResult GetAllEmpExpenses(int pageNumber = 1, int pageSize = 10)
        {
            var res = servies.GetAllEmpExpenses().ToList();

            var pagedData = Pagination.PagedResult(res, pageNumber, pageSize);
            return Json(pagedData);
        }
        public IActionResult GetEmpExpensesById(int Id)
        {
            var res = servies.GetEmpExpensesById(Id);
            return Json(res);
        }
    }
}
