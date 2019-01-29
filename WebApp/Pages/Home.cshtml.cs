using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Web.Pages.Shared;
using log4net;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Rest;
using WebApp.Dal;

namespace WebApp.Web.Pages
{
    public class HomeModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly ILog _logger = LogManager.GetLogger(typeof(HomeModel));
        private readonly AzureWebAppContext _context;

        public HomeModel(IConfiguration configuration, AzureWebAppContext context)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public List<ProgramSummaryModel> Programs { get; private set; }
        public string Message { get; private set; }

        public async Task OnGetAsync()
        {
            _logger.Info("Home Page");
            Message = _configuration.GetValue<string>("Message");
            var listProgram = _context.Programs.ToList();

            Programs = listProgram.Select(x => new ProgramSummaryModel
                {ProgramId = x.Id, BusinessSubLine = x.BusinessLine, ClientHolding = x.Client}).ToList();
           
            //Programs = new List<ProgramSummaryModel>()
            //{
            //    new ProgramSummaryModel{ProgramId = 1, BusinessSubLine = "1", UnderWritingYear = 2019},
            //    new ProgramSummaryModel{ProgramId = 2, BusinessSubLine = "2", UnderWritingYear = 2020}
            //};
        }
    }
}