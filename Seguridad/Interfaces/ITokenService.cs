using Seguridad.Models;

namespace Seguridad.Interfaces
{
    //Declaracion de la interface de tokens
    public interface ITokenService
    {
        //Metodo creacion de token en la implemnetacion
        string CreateToken(Users user);  

    }
}
