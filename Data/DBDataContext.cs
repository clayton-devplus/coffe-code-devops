﻿using CoffeCodeDevops.Data.Configurations;
using CoffeCodeDevops.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeCodeDevops.Data
{


    public class DBDataContext : DbContext
    {
        public DbSet<TestTableModel> TestTable { get; set; }
        public DbSet<FeedbackModel> Feedbacks { get; set; }

        public IConfiguration Configuration { get; }

        public DBDataContext()
        {

        }
        public IConfigurationRoot GetConfiguration()
        {
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            if (env == "Kubernetes")
            {
                var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.Kubernetes.json", optional: true, reloadOnChange: true)
                                                                                                     .AddEnvironmentVariables();
                return builder.Build();
            }
            else
            {
                var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                                                                                                     .AddEnvironmentVariables();
                return builder.Build();
            }

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = GetConfiguration();
            optionsBuilder.UseNpgsql(config.GetConnectionString("Postgres"));

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TestTableConfiguration());
            modelBuilder.ApplyConfiguration(new FeedbackConfiguration());
        }
    }

}
