using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace WebApp.Web.Pages.Shared
{
    public class ProgramSummaryModel : PageModel
    {
        [Display(Name = "Program Id")]
        public int ProgramId { get; set; }
        [Display(Name = "Client holding")]
        public string ClientHolding { get; set; }
        [Display(Name = "Business sub-line")]
        public string BusinessSubLine { get; set; }
        [Display(Name = "Underwriting year")]
        public int UnderWritingYear { get; set; }
    }
}