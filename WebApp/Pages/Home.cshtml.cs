using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.BL;
using WebApp.Web.Pages.Shared;
using log4net;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Rest;
using UWProgramApi.v1_0;
using UWProgramApi.v1_0.Models;

namespace WebApp.Web.Pages
{
    public class HomeModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly ILog _logger = LogManager.GetLogger(typeof(HomeModel));

        public HomeModel(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public List<ProgramSummaryModel> Programs { get; private set; }
        public async Task OnGetAsync()
        {
            _logger.Info("Home Page");
            //var authenticationSection = _configuration.GetSection("Authentication");
            //var accessToken = await HttpContext.GetTokenAsync(authenticationSection.GetValue<string>("CookieName"), "access_token");
            //var programClient = new UWProgramApiClient(new Uri(_configuration.GetValue<string>("app:UWProgramApi_baseUri")), new TokenCredentials(accessToken));
            //var programService = new UWProgramService(programClient);
            //var programs = await programService.GetDesiredUWProgramsAsync();
            var programs = new List<ProgramDto>()
            {
                new ProgramDto{ProgramId = 1, BusinessSubLineId = 1, UnderwritingYear = 2019},
                new ProgramDto{ProgramId = 2, BusinessSubLineId = 1, UnderwritingYear = 2020}
            };

            Programs = programs.Select(p => new ProgramSummaryModel
                {ProgramId = (int) p.ProgramId, BusinessSubLine = p.BusinessSubLineId.ToString(), UnderWritingYear = (int)p.UnderwritingYear}).ToList();
        }
    }
}