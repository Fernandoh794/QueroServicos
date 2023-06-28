﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using QueroServicos.Data;
using QueroServicos.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace QueroServicos.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private IConfiguration _config;

        private readonly ApplicationDbContext _context;


        public LoginController(IConfiguration config, ApplicationDbContext dbContext)
        {
            _config = config;
            _context = dbContext;
        }


        private User AuthenticateUser(User user)
        {
            // Procurar o usuário no banco de dados com base no e-mail e senha fornecidos
            var authenticatedUser = _context.Users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);

            // Retornar o usuário autenticado ou null caso não seja encontrado
            return authenticatedUser;
        }

        private String GenerateToken(User user)
        {
             var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
             var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"], _config["Jwt:Audience"], null,
                expires: DateTime.Now.AddMinutes(5),
                signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            IActionResult response = Unauthorized();
            var user = new User { Email = email, Password = password };
            var authenticatedUser = AuthenticateUser(user);

            if (authenticatedUser != null)
            {
                var tokenString = GenerateToken(authenticatedUser);
                response = Ok(new { token = tokenString });
            }

            return response;
        }


    }
}
