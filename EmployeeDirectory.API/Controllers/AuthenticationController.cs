using EmployeeDirectory.API;
using IdentityServer3.Core.Models;
using IdentityServer3.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace EmployeeDirectory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        public static User user = new User();
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;


        public AuthenticationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("CreateToken")]
        public async Task<string> LogIn(string username, string password)
        {
            //int userId = CheckPassword(username, password);
            //if (IsSignedUp(username, password) && userId != -1)
            //{
              var claims = new[]{
                                     new Claim("Name",username)
              };
               var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));
               var Credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
                var token = new JwtSecurityToken(
                claims:claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: Credentials

                 );
                var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
                return jwtToken;
            }
        }

        //private bool IsSignedUp(string username, string password)
        //{
        //    throw new NotImplementedException();
        //}

        //private int CheckPassword(string username, string password)
        //{
        //    throw new NotImplementedException();
        //}
    }
