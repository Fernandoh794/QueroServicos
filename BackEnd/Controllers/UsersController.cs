using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QueroServicos.Data;
using QueroServicos.Models;
using BCrypt.Net;
using System.Net;
using System.Runtime.ConstrainedExecution;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


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

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _context.Users
                .Include(u => u.Category)
                .Include(u => u.Address)
                .Where(u => u.type == "2")
                .ToListAsync();
            await _context.neighborhoods.ToListAsync();
            await _context.Cities.ToListAsync();
            await _context.States.ToListAsync();

            if (users.Count == 0)
            {
                return NotFound();
            }

            return users;
        }


        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users
                .Include(u => u.Category)
                .Include(u => u.Address)
                .FirstOrDefaultAsync(u => u.Id == id);
            await _context.neighborhoods.ToListAsync();
            await _context.Cities.ToListAsync();
            await _context.States.ToListAsync();

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }


        [Authorize]
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

        [Authorize]
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

        [Authorize]
        private bool UserExists(int id)
        {
            return (_context.Users?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        [Authorize]
        [HttpGet("category/{CategoryId}")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers(int CategoryId)
        {
            var query = _context.Users
                .Include(u => u.Category)
                .Include(u => u.Address)
                .Where(u => u.CategoryId == CategoryId && u.type == "2");
            await _context.neighborhoods.ToListAsync();
            await _context.Cities.ToListAsync();
            await _context.States.ToListAsync();

            var users = await query.ToListAsync();

            if (users.Count == 0)
            {
                return NotFound();
            }

            return users;
        }


        [Authorize]
        [HttpGet("search/{name}")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers(string name)
        {
            if (_context == null)
            {
                return NotFound();
            }

            var lowerName = name.ToLower();

            var users = await _context.Users
                .Where(u => (u.FirstName.ToLower() == lowerName || u.LastName.ToLower() == lowerName) && u.type == "2")
                .Include(u => u.Category)
                .Include(u => u.Address)
                .ToListAsync();
            await _context.neighborhoods.ToListAsync();
            await _context.Cities.ToListAsync();
            await _context.States.ToListAsync();

            if (users.Count == 0)
            {
                return NotFound();
            }

            return users;
        }


        [Authorize]
        [HttpPut("updateProfile/{id}")]
        public async Task<IActionResult> PutUpdateUser(int id, User updatedProfileUser)
        {
            var existingUser = await _context.Users.FindAsync(id);

            if (existingUser == null)
            {
                return NotFound();
            }

            existingUser.FirstName = updatedProfileUser.FirstName;
            existingUser.LastName = updatedProfileUser.LastName;
            existingUser.Email = updatedProfileUser.Email;
            existingUser.CpfCnpj = updatedProfileUser.CpfCnpj;
            existingUser.UpdatedAt = updatedProfileUser.UpdatedAt;

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


    }
}
