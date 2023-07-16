using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QueroServicos.Data;
using QueroServicos.Models;

namespace QueroServicos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NeighborhoodsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public NeighborhoodsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Neighborhoods
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Neighborhood>>> Getneighborhoods()
        {
          if (_context.neighborhoods == null)
          {
              return NotFound();
          }
            var city = await _context.Cities.ToListAsync();
            var state = await _context.States.ToListAsync();
            return await _context.neighborhoods.ToListAsync();
        }

        // GET: api/Neighborhoods/5
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<Neighborhood>> GetNeighborhood(int id)
        {
          if (_context.neighborhoods == null)
          {
              return NotFound();
          }
            var neighborhood = await _context.neighborhoods.FindAsync(id);
            var city = await _context.Cities.ToListAsync();
            if (neighborhood == null)
            {
                return NotFound();
            }

            return neighborhood;
        }

        // PUT: api/Neighborhoods/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNeighborhood(int id, Neighborhood neighborhood)
        {
            if (id != neighborhood.Id)
            {
                return BadRequest();
            }

            _context.Entry(neighborhood).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NeighborhoodExists(id))
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

        // POST: api/Neighborhoods
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPost]
        public async Task<ActionResult<Neighborhood>> PostNeighborhood(Neighborhood neighborhood)
        {
          if (_context.neighborhoods == null)
          {
              return Problem("Entity set 'ApplicationDbContext.neighborhoods'  is null.");
          }
            _context.neighborhoods.Add(neighborhood);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNeighborhood", new { id = neighborhood.Id }, neighborhood);
        }

        // DELETE: api/Neighborhoods/5
        [Authorize]
        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteNeighborhood(int id)
        {
            if (_context.neighborhoods == null)
            {
                return NotFound();
            }
            var neighborhood = await _context.neighborhoods.FindAsync(id);
            if (neighborhood == null)
            {
                return NotFound();
            }

            _context.neighborhoods.Remove(neighborhood);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NeighborhoodExists(int id)
        {
            return (_context.neighborhoods?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
