using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Context
{
    public class MasterContext:DbContext
    {
        public IConfiguration configuration;
        public MasterContext(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder )
        {
            base.OnConfiguring(optionsBuilder);
            var connectionString = configuration.GetConnectionString("DefaultConn");
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Apertment> Apertments { get; set; }
        public DbSet<CollectiveDebit> collectiveDebits { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Debit> Debits { get; set; }
        public DbSet<UserPassword> UserPasswords { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
        }
    }
}
