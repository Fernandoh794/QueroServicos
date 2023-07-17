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
    public class UserFeedbacksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserFeedbacksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/UserFeedbacks
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserFeedback>>> GetUserFeedback()
        {
          if (_context.UserFeedback == null)
          {
              return NotFound();
          }
            await _context.Users.ToListAsync();
            return await _context.UserFeedback.ToListAsync();
        }

        // GET: api/UserFeedbacks/5
        [Authorize]
        [HttpGet("userprofessional/{id}")]
        public async Task<ActionResult<IEnumerable<UserFeedback>>> GetUserFeedback(int id)
        {
            var userProfessional = await _context.Users.FindAsync(id);

            if (userProfessional == null || userProfessional.type != "2")
            {
                return NotFound();
            }
            await _context.Users.ToListAsync();
#pragma warning disable CS8602 // Desreferência de uma referência possivelmente nula.
#pragma warning disable CS8604 // Possível argumento de referência nula.
            var userFeedbacks = await _context.UserFeedback
                .Where(u => u.User.Id == id)
                .ToListAsync();
#pragma warning restore CS8604 // Possível argumento de referência nula.
#pragma warning restore CS8602 // Desreferência de uma referência possivelmente nula.

            if (userFeedbacks.Count == 0)
            {
                return NotFound();
            }

            return userFeedbacks;
        }


        // PUT: api/UserFeedbacks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserFeedback(int id, UserFeedback userFeedback)
        {
            if (id != userFeedback.Id)
            {
                return BadRequest();
            }

            _context.Entry(userFeedback).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserFeedbackExists(id))
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

        // POST: api/UserFeedbacks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
      [Authorize]
        [HttpPost]
        public async Task<ActionResult<UserFeedback>> PostUserFeedback(UserFeedback userFeedback)
        {
          if (_context.UserFeedback == null)
          {
              return Problem("Entity set 'ApplicationDbContext.UserFeedback'  is null.");
          }
            _context.UserFeedback.Add(userFeedback);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserFeedback", new { id = userFeedback.Id }, userFeedback);
        }

        // DELETE: api/UserFeedbacks/5
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserFeedback(int id)
        {
            if (_context.UserFeedback == null)
            {
                return NotFound();
            }
            var userFeedback = await _context.UserFeedback.FindAsync(id);
            if (userFeedback == null)
            {
                return NotFound();
            }

            _context.UserFeedback.Remove(userFeedback);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserFeedbackExists(int id)
        {
            return (_context.UserFeedback?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
