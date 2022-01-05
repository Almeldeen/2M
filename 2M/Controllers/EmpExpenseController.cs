using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2M.Controllers
{
    public class EmpExpenseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
