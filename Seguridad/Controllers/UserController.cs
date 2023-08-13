using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Seguridad.Data;
using Seguridad.Interfaces;
using Seguridad.Models;
using System.Linq;

namespace Seguridad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly DataContext _context;
        private readonly ITokenService _tokenService;

        public UserController(DataContext context, ITokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

       
        [HttpGet("{id}")]
        public async Task<ActionResult<Users>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Users>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }
            
    }
}
