using Enquete.ApplicationCore.Entities;
using Enquete.Infrastructure.EntityConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Enquete.Infrastructure.Context
{
    public class EnqueteContext : DbContext
    {
        public EnqueteContext() { }
        public EnqueteContext(DbContextOptions<EnqueteContext> opcoes) : base(opcoes) { }

        public DbSet<Poll> Poll { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration.Remove<PluralizingTableNameConvention>(); //plularização de objetos
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); //deleção em cascata de filho
            modelBuilder.ApplyConfiguration(new PoolConfig());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
