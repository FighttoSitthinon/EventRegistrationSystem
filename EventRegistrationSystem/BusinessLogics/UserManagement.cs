using EventRegistrationSystem.Models.Dto;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace EventRegistrationSystem.BusinessLogics
{
    public class UserManagement
    {
        private const string Secret = "QyZGKUhATWM5eSRCJkUoSHM1djh5L0I/WG4ycjV1OHhmVGpXblpyNE1iUWVUaFdtKEcrS2JQZVNBP0QqRy1LYTd4IUElRCpGcTR0N3cheiU=";

        public UserManagement()
        {

        }
        
        public string GenerateToken(UserDto user, int expireMinutes = 60)
        {
            var symmetricKey = Convert.FromBase64String(Secret);
            var tokenHandler = new JwtSecurityTokenHandler();

            var now = DateTime.UtcNow;
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("Id", user.Id),
                    new Claim("Email", user.Email),
                    //new Claim("Role", user.Role),
                }),

                Expires = now.AddMinutes(Convert.ToInt32(expireMinutes)),

                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(symmetricKey),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var stoken = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(stoken);

            return token;
        }

        public UserDto DecodeJWTToken(string jwt)
        {
            UserDto user = new UserDto();
            try
            {
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(jwt);
                var tokenS = jsonToken as JwtSecurityToken;

                user.Id = tokenS.Claims.First(claim => claim.Type == "Id").Value;
                user.Email = tokenS.Claims.First(claim => claim.Type == "Email").Value;
                //user.Role = tokenS.Claims.First(claim => claim.Type == "Role").Value;

                return user;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
