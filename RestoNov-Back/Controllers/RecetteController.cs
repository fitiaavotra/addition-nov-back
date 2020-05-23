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
    public class RecetteController : ControllerBase
    {
        public IRecetteRepository _recetteRepository;

        public RecetteController(IRecetteRepository recetteRepository)
        {

            _recetteRepository = recetteRepository;

        }

        [HttpGet]
        public async Task<IEnumerable<Recette>> Get()
        {
            
            return _recetteRepository.GetAll();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Recette obj)
        {
            await _recetteRepository.Create(obj);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Recette obj)
        {
            await _recetteRepository.Update(id, obj);
            return Ok();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _recetteRepository.Delete(id);
            return Ok();
        }


    }
}