using BLL.Servies;
using DAL.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resturant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServies servies;

        public UserController( IUserServies servies)
        {
            this.servies = servies;
        }
        [HttpPost("AddUser")]
        public IActionResult AddUser (UserVM user)
        {
            var res = servies.AddUser(user);
            if (res == true)
            {
                return Ok("Added Sucssesful");
            }
            return BadRequest("Error");
           
                
        }
        [HttpPost("LogIn")]
        public IActionResult LogIn (UserVM user)
        {
            var res = servies.LogIn(user);
            if (res == true)
            {
                return Ok("welcome ");
            }
            return BadRequest("Try Again");
        }

    }
}
