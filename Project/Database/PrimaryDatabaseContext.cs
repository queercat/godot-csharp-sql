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
        public DbSet<Food> Foods { get; set; }
        public string ConnectionString { get; set; }

        public PrimaryDatabaseContext()
        {
            ConnectionString = "MY_CONNECTION_STRING";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionString);
        }
    }
}
