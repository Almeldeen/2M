using BLL.Servies.Categorie;
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
    public class CategorieController : ControllerBase
    {
        private readonly ICategorieServies servies;

        public CategorieController( ICategorieServies servies)
        {
            this.servies = servies;
        }
        [HttpPost("AddCategorie")]
        public IActionResult AddCategorie(CategorieVM categorie)
        {
            var res = servies.AddCategorie(categorie);
            if (res == true)
            {
                return Ok("Added Sucssesful");
            }
            return BadRequest("Error");

        }
        [HttpPost("EditCategorie")]
        public IActionResult EditCategorie(CategorieVM categorie)
        {
            var res = servies.EditCategorie(categorie);
            if (res == true)
            {
                return Ok("Added Sucssesful");
            }
            return BadRequest("Error");
        }
        [HttpGet("GetAllCategorie")]
        public IActionResult GetAllCategorie()
        {
            var res = servies.GetAllCategorie();
            return Ok(res);

        }
        [HttpGet("GetByIdCategorie")]
        public IActionResult GetByIdCategorie(int Id)
        {
            var res = servies.GetByIdCategorie(Id);
            return Ok(res);

        }
    }
}
