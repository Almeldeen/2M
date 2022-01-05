using BLL.Helper;
using BLL.Services.AttendServies;
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
       

        public AttendanceController(IAttendServies servies)
        {
            this.servies = servies;
          
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAllAttend(DateTime date,int pageNumber = 1, int pageSize = 10)
        {
            var res = servies.GetAllAttend(date).ToList();
            var pagedData = Pagination.PagedResult(res, pageNumber, pageSize);
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
            return View();
        }

    }
}
