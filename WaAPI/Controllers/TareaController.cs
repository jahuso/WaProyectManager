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
    public class TareaController : ControllerBase
    {

        private readonly IGenericRepository<Tarea> _genericRepository;

        public TareaController(IGenericRepository<Tarea> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        // GET: api/Tarea
        [HttpGet]
        public  Task<IEnumerable<Tarea>> GetTarea()
        {
            return _genericRepository.GetAll();
        }

        // GET: api/Tarea/5
        [HttpGet("{id}")]
        public IActionResult GetTarea(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tarea = _genericRepository.GetbyId(id);

            if (tarea == null)
            {
                return NotFound();
            }

            return Ok(tarea);
        }

        // PUT: api/Tarea/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTarea(int id, Tarea tarea)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tarea.Codigo)
            {
                return BadRequest();
            }

            try
            {
                await _genericRepository.Update(tarea);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }

        // POST: api/Tarea
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tarea>> PostTarea(Tarea tarea)
        {
            await _genericRepository.Add(tarea);
            return CreatedAtAction("GetTarea", new { id = tarea.Codigo }, tarea);
        }

        // DELETE: api/Tarea/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tarea>> DeleteTarea(int id)
        {
            var tarea = _genericRepository.GetbyId(id);
            if (tarea == null)
            {
                return NotFound();
            }

            _genericRepository.Delete(tarea);

            return tarea;
        }
    }
}
