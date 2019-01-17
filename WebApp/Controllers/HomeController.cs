using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.BL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UWProgramApi.v1_0;
using Microsoft.Extensions.Configuration;
using Microsoft.Rest;
using Microsoft.AspNetCore.Authentication;
using log4net;
using WebApp.Web.Pages;

namespace WebApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private IUWProgramService programService;
        private readonly IConfiguration configuration;
        private readonly ILog _logger = LogManager.GetLogger(typeof(HomeController));

        public HomeController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public IActionResult Index()
        {
            _logger.Info("Home Page");
            return null;
        }
    }
}