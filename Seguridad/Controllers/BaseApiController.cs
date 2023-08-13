using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Seguridad.Controllers

    //controlador base para heredar a todos los controladores de la explicacion
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {

    }
}
