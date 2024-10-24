using Consius.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Consius.Host.Controllers
{
    [Route("v1/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController()
        {
            
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Create(User obj)
        {
            return Ok(obj);
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(User obj)
        {
            return Ok(obj);
        }
    }
}
