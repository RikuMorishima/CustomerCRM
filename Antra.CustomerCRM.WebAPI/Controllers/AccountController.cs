using Antra.CustomerCRM.Core.Contracts.Service;
using Antra.CustomerCRM.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Antra.CustomerCRM.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountServiceAsync accountService;
        private readonly IConfiguration configuration;
        public AccountController(IAccountServiceAsync accountService, IConfiguration configuration)
        {
            this.accountService = accountService;
            this.configuration = configuration;
        }

        [HttpPost]
        [Route("signup")]
        public async Task<IActionResult> SignUpAsync(SignUpModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = await accountService.SignUpAsync(model);
            if (result.Succeeded)
            {
                return Ok(new { Message = "User has been created successfully" });
            }
            StringBuilder sb = new();
            foreach(var item in result.Errors)
            {
                sb.Append(item.Description);
            }
            return BadRequest(sb.ToString());
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var result = await accountService.LoginAsync(model);
            if (!result.Succeeded)
                return Unauthorized(new {Message="Invalid Username or Password"});

            // list of claims
            var authClaims = new List<Claim> {
                new Claim(ClaimTypes.Name, model.Email),
                new Claim(ClaimTypes.Country, "USA"),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
            };

            var authKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));
            var token = new JwtSecurityToken(
                issuer: configuration["JWT:ValidIssuer"],
                    audience: configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddDays(1),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authKey,SecurityAlgorithms.HmacSha256Signature)
                );
            var t = new JwtSecurityTokenHandler().WriteToken(token);
            return Ok(new {jwt=t});
        }
    }
}
