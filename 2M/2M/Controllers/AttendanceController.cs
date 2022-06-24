using BLL.Helper;
using BLL.Services.AttendServies;
using BLL.Services.EmpServies;
using DAL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace _2M.Controllers
{
    public class AttendanceController : Controller
    {
        private readonly IAttendServies servies;
        private readonly IEmpServies emp;

        public AttendanceController(IAttendServies servies,IEmpServies emp)
        {
            this.servies = servies;
            this.emp = emp;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAllAttend(DateTime date,int pageNumber = 1, int pageSize = 10)
        {
            var res = servies.GetAllAttend(date).ToList();
            var pagedData = Pagination.PagedResult(res.SkipWhile(x => x.AttendReg == true).ToList(), pageNumber, pageSize);
            return Json(pagedData);
                
        }
        public IActionResult AddAttend(AttendVM Attend)
        {
            //CultureInfo provider = new CultureInfo("fr-FR");
            //string format = "d";
            //Attend.Date = DateTime.ParseExact(Attend.DateStr, format, provider);

            var data = servies.AddAttend(Attend);
            return Json(data);
        }
        public IActionResult ViewEmpAttend()
        {
            ViewBag.Emp = emp.GetAllEmp().ToList();
            return View();
        }
        public IActionResult GetAttendById(int Id, DateTime start, DateTime end)
        {
            return Json(servies.GetAttendById(Id, start, end).ToList());
        }

    }
}
