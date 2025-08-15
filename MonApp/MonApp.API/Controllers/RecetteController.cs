using Microsoft.AspNetCore.Mvc;
using MonApp.Application.Interfaces;
using MonApp.Domaine.Models;

namespace MonApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecetteController : ControllerBase
    {
        private readonly IRecetteService _service;

        public RecetteController(IRecetteService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => 
        Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var recette = await _service.GetByIdAsync(id);
            return recette == null ? NotFound() : Ok(recette);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Recette recette)
        {
            var created = await _service.CreateAsync(recette);
            return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Recette recette)
        {
            if (id != recette.Id) return BadRequest();
            var result = await _service.UpdateAsync(id, recette);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);
            return result == -1 ? BadRequest() : NoContent();
        }
    }
}
