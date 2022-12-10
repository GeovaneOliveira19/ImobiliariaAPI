using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ImobiliariaAPI;
using ImobiliariaAPI.Dados;

namespace ImobiliariaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoImovelsController : ControllerBase
    {
        private readonly DadosBase _context;

        public TipoImovelsController(DadosBase context)
        {
            _context = context;
        }

        // GET: api/TipoImovels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoImovel>>> GetTipoImoveis()
        {
            return await _context.TipoImoveis.ToListAsync();
        }

        // GET: api/TipoImovels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoImovel>> GetTipoImovel(int id)
        {
            var tipoImovel = await _context.TipoImoveis.FindAsync(id);

            if (tipoImovel == null)
            {
                return NotFound();
            }

            return tipoImovel;
        }

        // PUT: api/TipoImovels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoImovel(int id, TipoImovel tipoImovel)
        {
            if (id != tipoImovel.Id)
            {
                return BadRequest();
            }

            _context.Entry(tipoImovel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoImovelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TipoImovels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TipoImovel>> PostTipoImovel(TipoImovel tipoImovel)
        {
            _context.TipoImoveis.Add(tipoImovel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoImovel", new { id = tipoImovel.Id }, tipoImovel);
        }

        // DELETE: api/TipoImovels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoImovel(int id)
        {
            var tipoImovel = await _context.TipoImoveis.FindAsync(id);
            if (tipoImovel == null)
            {
                return NotFound();
            }

            _context.TipoImoveis.Remove(tipoImovel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TipoImovelExists(int id)
        {
            return _context.TipoImoveis.Any(e => e.Id == id);
        }
    }
}
