using System.ComponentModel.DataAnnotations;

namespace Seguridad.Dto
{
    public class RegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
            
    }
}
