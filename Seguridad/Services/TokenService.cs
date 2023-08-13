using Microsoft.IdentityModel.Tokens;
using Seguridad.Interfaces;
using Seguridad.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Seguridad.Services
{
    public class TokenService : ITokenService
    {
        private readonly SymmetricSecurityKey _key;
        public TokenService (IConfiguration configuration)
        {
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["TokenKey"]));
        }

        //crea un token
        public string CreateToken(Users user)
        {
            var claims = new List<Claim>();
            //informacion del token crwado
            var credenciales = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512Signature);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                //se agrega el nombre del indentificador
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(7),
                SigningCredentials = credenciales
            };
            //generadores el manejador del token de seguridad
            var tokenHandler = new JwtSecurityTokenHandler();
            //creamos el jwtToken con la descripcion
            var token = tokenHandler.CreateToken(tokenDescriptor);
            //serializa el token para poder ser enviado
            return tokenHandler.WriteToken(token);
        }
    }
}
