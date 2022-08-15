using DataLayer.Entities;
using DTO.User;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Auth
{
    public class TokenProvider
    {
        private IConfiguration configuration;
        public TokenProvider(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public string CreateToken(UserDto user)
        {
            var Claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Aud, configuration["JWT:Audience"]),
                new Claim(JwtRegisteredClaimNames.Iss, configuration["JWT:Issuer"]),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim("Name", "fatma")
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Key"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(configuration["JWT:Issuer"], configuration["JWT:Audience"], Claims, DateTime.Now, DateTime.Now.AddMinutes(20), signIn);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
