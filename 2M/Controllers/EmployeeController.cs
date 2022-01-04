using BLL.Helper;
using BLL.Services.EmpServies;
using DAL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2M.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmpServies servies;

        public EmployeeController(IEmpServies servies)
        {
            this.servies = servies;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddEmp(EmpVM Emp)
        {
            var res = servies.AddEmp(Emp);
            return Json(res);
        }
        public IActionResult EditEmp(EmpVM Emp)
        {
            var res = servies.EditEmp(Emp);
            return Json(res);
        }
        public IActionResult DeleteEmp(int Id)
        {
            var res = servies.DeleteEmp(Id);
            return Json(res);
        }
        public IActionResult GetAllEmp(int pageNumber = 1, int pageSize = 10)
        {
            var res = servies.GetAllEmp().ToList();
            var pagedData = Pagination.PagedResult(res, pageNumber, pageSize);
            return Json(pagedData);
        }
        public IActionResult GetEmpById(int Id)
        {
            var res = servies.GetEmpById(Id);
            return Json(res);
        }

    }
}
