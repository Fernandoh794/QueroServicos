using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QueroServicos.Data;
using QueroServicos.Models;
using BCrypt.Net;
using System.Net;
using System.Runtime.ConstrainedExecution;


namespace QueroServicos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        //TIREI O [AUTORIZE] PARA TESTAR, RELAXA AI QUE JA JA COLOCO
        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            IQueryable<User> query = _context.Users;
            string? type = "2";
            if (!string.IsNullOrEmpty(type) && type == "2")
            {
                query = query.Where(u => u.type == type);
                await _context.Categories.ToListAsync();
                await _context.Address.ToListAsync();
                await _context.neighborhoods.ToListAsync();
                await _context.Cities.ToListAsync();
                await _context.States.ToListAsync();
            }
            else
            {
                return new List<User>();
            }

            var users = await query.ToListAsync();

            if (users == null || users.Count == 0)
            {
                return NotFound();
            }

            return users;
        }


        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
          if (_context.Users == null)
          {
              return NotFound();
          }
            await _context.Categories.ToListAsync();
            await _context.Address.ToListAsync();
            await _context.neighborhoods.ToListAsync();
            await _context.Cities.ToListAsync();
            await _context.States.ToListAsync();
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User updatedUser)
        {
            var existingUser = await _context.Users.FindAsync(id);

            if (existingUser == null)
            {
                return NotFound();
            }

            existingUser.type = updatedUser.type ?? existingUser.type;
            existingUser.AddressId = updatedUser.AddressId ?? existingUser.AddressId;
            existingUser.Address = updatedUser.Address;
            existingUser.CategoryId = updatedUser.CategoryId;
            existingUser.Imagem = updatedUser.Imagem;
            existingUser.UpdatedAt = updatedUser.UpdatedAt;
            existingUser.Whatsapp = updatedUser.Whatsapp;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // Tratamento de exceção para concorrência otimista
                return NotFound();
            }

            return NoContent();
        }


        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
          if (_context.Users == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Users'  is null.");
          }

            bool userExists = await _context.Users.AnyAsync(u => u.Email == user.Email);

            if (userExists)
            {
                return BadRequest("Email já Registrado.");
            }

            bool userExist = await _context.Users.AnyAsync(u => u.CpfCnpj == user.CpfCnpj);

            if (userExist)
            {
                return BadRequest("CPF já Registrado.");
            }




            string passwordHash = BCrypt.Net.BCrypt.HashPassword(user.Password);
            user.Password = passwordHash;

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            if (_context.Users == null)
            {
                return NotFound();
            }
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(int id)
        {
            return (_context.Users?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        [HttpGet("category/{CategoryId}")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers(int CategoryId)
        {
            IQueryable<User> query = _context.Users;
            string? type = "2";
            if (!string.IsNullOrEmpty(type) && type == "2")
            {
                query = query.Where(e => e.CategoryId == CategoryId && e.type == type);
                await _context.Categories.ToListAsync();
                await _context.Address.ToListAsync();
                await _context.neighborhoods.ToListAsync();
                await _context.Cities.ToListAsync();
                await _context.States.ToListAsync();
            }
            else
            {
                return new List<User>();
            }

            var users = await query.ToListAsync();

            if (users == null || users.Count == 0)
            {
                return NotFound();
            }

            return users;
        }
    }
}
