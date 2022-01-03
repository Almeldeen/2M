﻿using BLL.Services.JopService;
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
        public IActionResult EditJop(JopVM jop)
        {
            var res = service.EditJop(jop);
            return Json(res);
        }
        public IActionResult DeleteJop(int Id)
        {
            var res = service.DeleteJop(Id);
            return Json(res);
        }
        public IActionResult GetAllJop()
        {
            var res = service.GetAllJop();
            return Json(res);
        }
        public IActionResult GetJopById(int Id)
        {
            var res = service.GetJopById(Id);
            return Json(res);
        }
    }
}
