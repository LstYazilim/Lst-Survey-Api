using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using LstSurveyApi.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using LstSurveyApi.Context;

namespace JwtControllers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly UserContext _context;

        public UsersController(IConfiguration config, UserContext context)
        {
            _config = config;
            _context = context;
        }
        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody] SurveyUser login)
        {
            IActionResult response = Unauthorized();
            var user = AuthenticateUser(login);

            if (user != null)
            {
                var tokenString = GenerateJSONWebToken(user);
                response = Ok(new { token = tokenString });
            }

            return response;
        }
        [Authorize]
        [HttpGet("{id}")]
        public ActionResult<SurveyUser> GetUser(int id)
        {
            var user = _context.SurveyUser.FirstOrDefault(u => u.UserId == id);

            if (user == null)
            {
                return NotFound();
            }

            return user;

        }


        [Authorize]
        [HttpGet]
        public IEnumerable<SurveyUser> GetUsers()
        {
            return _context.SurveyUser.ToList();
        }
        private SurveyUser AuthenticateUser(SurveyUser login)
        {
            var user = _context.SurveyUser.SingleOrDefault(u => u.UserName == login.UserName && u.UserPassword == login.UserPassword);
            return user;
        }

        private string GenerateJSONWebToken(SurveyUser userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            if (securityKey.KeySize < 128)
            {
                securityKey = new SymmetricSecurityKey(new byte[16]); // Or some other method to generate a larger key
            }
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userInfo.UserId.ToString()),
                new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            var token = new JwtSecurityToken(
             issuer: _config["Jwt:Issuer"],
        audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(Convert.ToInt32(_config["Jwt:ExpiryInMinutes"])),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}