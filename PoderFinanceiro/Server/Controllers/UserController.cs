using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoderFinanceiro.Shared;
using PoderFinanceiro.Shared.Models;

namespace PoderFinanceiro.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO login)
        {

            SessionDTO session = new();

            if(login == null) throw new ArgumentNullException(nameof(login));
            else if(login.Email == "admin@gmail.com" && login.Password == "admin")
            {
                session.Name = "Bruno Costa";
                session.Email = login.Email;
                session.Function = "Administrator";
            }
            else
            {
                session.Name = "Bruno Costa";
                session.Email = login.Email;
                session.Function = "Client"; 
            }

            return StatusCode(StatusCodes.Status200OK, session);

        }

    }
}
