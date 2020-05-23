using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestoNov_Back.Models;
using RestoNov_Back.Repository.Recette;

namespace RestoNov_Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
       



        [HttpGet]
        public async Task<IEnumerable<Ingredient>> Get()
        {
            
            return new List<Ingredient>();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Ingredient obj)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Ingredient obj)
        {
          
            return Ok();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            
            return Ok();
        }


    }
}