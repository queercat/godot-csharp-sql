using Microsoft.EntityFrameworkCore;
using Project.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Database
{
    public class PrimaryDatabaseContext : DbContext
    {
        internal DbSet<Food> Foods { get; set; }
        public string ConnectionString { get; set; }

        public PrimaryDatabaseContext()
        {
            // User ID=postgres;Password=postgres;Host=localhost;Port=5432;Database=database;
            ConnectionString = "YOUR_CONNECTION_STRING";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionString);
        }
    }
}
