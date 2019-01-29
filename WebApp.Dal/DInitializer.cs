using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApp.Dal.Models;

namespace WebApp.Dal
{
    public static class DInitializer
    {
        public static void Initialize(AzureWebAppContext context)
        {
            if (context.Programs.Any())
                return;

            var programs = new Program[]
            {
                new Program {BusinessLine="Chemical", Client="Total", EffectiveDate = DateTimeOffset.UtcNow},
                new Program {BusinessLine="Energy", Client="Shell", EffectiveDate = DateTimeOffset.UtcNow},
                new Program {BusinessLine="Fuel", Client="TOTO", EffectiveDate = new DateTimeOffset(2015,12,1,12,10,0,new TimeSpan())}
            };

            context.Programs.AddRange(programs);
            context.SaveChanges();
        }
    }
}
