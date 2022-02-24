using EventRegistrationSystem.Models.Dto;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace EventRegistrationSystem.BusinessLogics
{
    public class UserManagement
    {
        private readonly string Secret;

        public UserManagement(IConfiguration configuration)
        {
            Secret = configuration.GetSection("AppSettings:SecretKey").Value;
        }

        public string GenerateToken(UserDto user, int day = 1)
        {
            var symmetricKey = Convert.FromBase64String(Secret);
            var tokenHandler = new JwtSecurityTokenHandler();

            var now = DateTime.UtcNow;

            var Claims = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, user.Email),
                new Claim(ClaimTypes.Email, user.Email),
            });

            if (user.Roles != null)
            {
                foreach (var role in user.Roles)
                {
                    Claims.AddClaim(new Claim(ClaimTypes.Role, role));
                }
            }
            
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = Claims,

                Expires = now.AddDays(day),

                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(symmetricKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var stoken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(stoken);

            return token;
        }

        //public UserDto DecodeJWTToken(string jwt)
        //{
        //    UserDto user = new UserDto();
        //    try
        //    {
        //        var handler = new JwtSecurityTokenHandler();
        //        var jsonToken = handler.ReadToken(jwt);
        //        var tokenS = jsonToken as JwtSecurityToken;

        //        user.Id = tokenS.Claims.First(claim => claim.Type == "Id").Value;
        //        user.Email = tokenS.Claims.First(claim => claim.Type == "Email").Value;
        //        user.Role = tokenS.Claims.First(claim => claim.Type == "Role").Value;

        //        return user;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}
    }
}
