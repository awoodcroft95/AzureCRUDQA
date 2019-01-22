using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureCRUDQA.Models;
using Microsoft.EntityFrameworkCore;

namespace AzureCRUDQA.Data
{
    public class AzureCRUDQAContext : DbContext
    {
        public AzureCRUDQAContext(DbContextOptions<AzureCRUDQAContext> options) : base(options)
        {
        }

        public DbSet<Accounts> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accounts>().ToTable("Accounts");
        }
    }
}
