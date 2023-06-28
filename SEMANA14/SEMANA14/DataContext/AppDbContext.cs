using Microsoft.EntityFrameworkCore;
using SEMANA14.Models;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace SEMANA14.DataContext
{
    public class AppDbContext : DbContext
    {
        string DbPath = string.Empty;

        public DbSet<Product> Products { get; set; }

        public AppDbContext(string dbPath)
        {
            DbPath = dbPath;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlite($"Name={DbPath}");
        }
    }
}
