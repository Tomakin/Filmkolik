using Filmkolik.ClassModels;
using Filmkolik.Library.Functions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmkolik.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        ILogger<LoginController> _logger;
        readonly IUserService _userService;
        public LoginController(IUserService userService, ILogger<LoginController> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            AuthenticateResponse response = _userService.Authenticate(model);

            if (response == null)
            {
                _logger.LogWarning($"{model.Username} kullanıcı adı ile kullanıcı girişi yapılamadı");
                return BadRequest(new { message = "Username or password is incorrect" });
            }

            _logger.LogWarning($"{model.Username} kullanıcı adlı kullanıcı giriş yaptı");
            return Ok(response);
        }
    }
}
