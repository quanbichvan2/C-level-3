using DataLayer.Models;
using System.Collections.Generic;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataLayer.Context
{
    public class ContactDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Member> Members { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=YUN;initial catalog=Lab7CSharp;integrated security=True;" +
                "MultipleActiveResultSets=True;App=EntityFramework;TrustServerCertificate=True");
        }
    }
}