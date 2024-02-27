using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstDBCreation.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstDBCreation.Context
{
    public class CodeFirstContext : DbContext
    {
        public DbSet<Company> companies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("data source=YUN;initial catalog=Company;integrated security=True;" +
                "MultipleActiveResultSets=True;App=EntityFramework;TrustServerCertificate=True");
        }
    }
}
