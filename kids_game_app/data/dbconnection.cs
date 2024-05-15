using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace kids_game_app.data
{
    internal class dbconnection : DbContext
    {
        public DbSet<user> users { get; set; }
     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace the connection string with your actual SQL Server connection string
            optionsBuilder.UseSqlServer(Properties.Settings.Default.ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<user>().HasIndex(u=>u.UserName).IsUnique();
            base.OnModelCreating(modelBuilder);
        }
    }
}
