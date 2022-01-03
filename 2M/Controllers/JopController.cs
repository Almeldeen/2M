using BLL.Services.JopService;
using DAL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2M.Controllers
{
    public class JopController : Controller
    {
        private readonly IJopService service;

        public JopController(IJopService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddJop(JopVM jop)
        {
            var res = service.AddJop(jop);
            return Json(res);
        }
    }
}
