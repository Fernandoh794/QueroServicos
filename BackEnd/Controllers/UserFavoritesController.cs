using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QueroServicos.Data;
using QueroServicos.Models;

namespace QueroServicos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserFavoritesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserFavoritesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/UserFavorites
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserFavorite>>> GetUserFavorite(int userId, int userIdFavoritado)
        {
            IQueryable<UserFavorite> query = _context.UserFavorite;

            if (userId > 0)
            {
                query = query.Where(uf => uf.UserId == userId);
            }

            if (userIdFavoritado > 0)
            {
                query = query.Where(uf => uf.UserFavoritadoId == userIdFavoritado);
            }

            var userFavorites = await query.ToListAsync();

            if (userFavorites == null)
            {
                return NotFound();
            }

            return userFavorites;
        }

        // GET: api/UserFavorites/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserFavorite>> GetUserFavorite(int id)
        {
          if (_context.UserFavorite == null)
          {
              return NotFound();
          }
            var userFavorite = await _context.UserFavorite.FindAsync(id);

            if (userFavorite == null)
            {
                return NotFound();
            }

            return userFavorite;
        }

        // PUT: api/UserFavorites/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserFavorite(int id, UserFavorite userFavorite)
        {
            if (id != userFavorite.Id)
            {
                return BadRequest();
            }

            _context.Entry(userFavorite).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserFavoriteExists(id))
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

        // POST: api/UserFavorites
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserFavorite>> PostUserFavorite(UserFavorite userFavorite)
        {
          if (_context.UserFavorite == null)
          {
              return Problem("Entity set 'ApplicationDbContext.UserFavorite'  is null.");
          }
            _context.UserFavorite.Add(userFavorite);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserFavorite", new { id = userFavorite.Id }, userFavorite);
        }

        // DELETE: api/UserFavorites/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserFavorite(int id)
        {
            if (_context.UserFavorite == null)
            {
                return NotFound();
            }
            var userFavorite = await _context.UserFavorite.FindAsync(id);
            if (userFavorite == null)
            {
                return NotFound();
            }

            _context.UserFavorite.Remove(userFavorite);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserFavoriteExists(int id)
        {
            return (_context.UserFavorite?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
