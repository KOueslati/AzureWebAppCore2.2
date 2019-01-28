using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WebApp.Dal.Models;

namespace WebApp.Dal
{
    public class AzureWebAppContext : DbContext
    {
        public AzureWebAppContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Program> Programs { get; set; }
    }
}
