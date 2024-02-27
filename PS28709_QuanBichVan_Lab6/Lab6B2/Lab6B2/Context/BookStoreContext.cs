using Lab6B2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6B2.Context
{
    public class BookStoreContext : DbContext
    {
        public DbSet<BookStore> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=YUN;initial catalog=BookStore;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookStore>().HasKey(e => e.BookId); // Configure BookId as the primary key
        }
    }
}
