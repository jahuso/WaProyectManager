using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectManager.Data;
using ProjectManager.Data.Context;
using ProjectManager.Data.Interfaces;

namespace WaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IGenericRepository<Persona> _genericRepository;


        public PersonaController(IGenericRepository<Persona> genericRepository)
        {
            _genericRepository = genericRepository;
        }


        // GET: api/Persona
        [HttpGet]
        public Task<IEnumerable<Persona>> GetTarea()
        {
            return _genericRepository.GetAll();
        }

        // GET: api/Persona/5
        [HttpGet("{id}")]
        public IActionResult GetTarea(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var persona = _genericRepository.GetbyId(id);

            if (persona == null)
            {
                return NotFound();
            }

            return Ok(persona);
        }

        // PUT: api/Persona/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersona(int id, Persona persona)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != persona.Identificacion)
            {
                return BadRequest();
            }

            try
            {
                await _genericRepository.Update(persona);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }

        // POST: api/Persona
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Persona>> PostPersona(Persona persona)
        {
            await _genericRepository.Add(persona);

            return CreatedAtAction("GetPersona", new { id = persona.Identificacion }, persona);
        }

        // DELETE: api/Persona/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Persona>> DeletePersona(int id)
        {
            var persona = _genericRepository.GetbyId(id);
            if (persona == null)
            {
                return NotFound();
            }

            _genericRepository.Delete(persona);

            return persona;
        }
    }
}
