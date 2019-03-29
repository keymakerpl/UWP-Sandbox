using System;
using Microsoft.EntityFrameworkCore;
using UWP.Core.Models;

namespace UWP.Core.Services
{

    public class RmaBuddyContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=rmabuddy.db");
        }
    }
}
