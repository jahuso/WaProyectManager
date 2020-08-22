using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectManager.Data;
using ProjectManager.Data.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProyectoController : ControllerBase
    {
        private readonly IGenericRepository<Proyecto> _genericRepository;

        public ProyectoController(IGenericRepository<Proyecto> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        // GET: api/Proyecto
        [HttpGet]
        public Task<IEnumerable<Proyecto>> GetProyecto()
        {
            return _genericRepository.GetAll();
        }

        // GET: api/Proyecto/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Proyecto>> GetProyecto(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var proyecto = _genericRepository.GetbyId(id);

            if (proyecto == null)
            {
                return NotFound();
            }

            return Ok(proyecto);
        }

        // PUT: api/Proyecto/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProyecto(int id, Proyecto proyecto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != proyecto.Codigo)
            {
                return BadRequest();
            }


            try
            {
                await _genericRepository.Update(proyecto);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }

        // POST: api/Proyecto
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Proyecto>> PostProyecto(Proyecto proyecto)
        {
            await _genericRepository.Add(proyecto);
            return CreatedAtAction("GetProyecto", new { id = proyecto.Codigo }, proyecto);
        }

        // DELETE: api/Proyecto/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Proyecto>> DeleteProyecto(int id)
        {
            var proyecto = _genericRepository.GetbyId(id);
            if (proyecto == null)
            {
                return NotFound();
            }

            _genericRepository.Delete(proyecto);

            return proyecto;
        }
    }
}
