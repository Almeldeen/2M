using BLL.Helper;
using BLL.Services.EmpExpensesService;
using BLL.Services.EmpServies;
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
        private readonly IEmpServies emp;

        public EmpExpenseController(IEmpExpensesServies servies, IEmpServies emp)
        {
            this.servies = servies;
            this.emp = emp;
        }
        public IActionResult Index()
        {
            ViewBag.Emp = emp.GetAllEmp().ToList();
            return View();
        }
        public IActionResult AddEmpExpenses(EmpExpensesVM EmpExpenses)
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
        public IActionResult ViewEmpExpense()
        {
            ViewBag.Emp = emp.GetAllEmp().ToList();
            return View();
        }
        public IActionResult GetAllEmpcallById(int Id, DateTime start, DateTime end)
        {
            var res = servies.GetAllEmpcallById(Id, start, end).ToList();
            return Json(res);
        }
    }
}
