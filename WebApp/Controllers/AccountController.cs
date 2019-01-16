using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace WebApp.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IConfiguration _configuration;

        public AccountController(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        [ValidateAntiForgeryToken]
        public async Task LogOff()
        {
            await HttpContext.SignOutAsync(_configuration.GetSection("Authentication")
                ?.GetValue<string>("CookieName"));
            await HttpContext.SignOutAsync("oidc");
        }
    }
}