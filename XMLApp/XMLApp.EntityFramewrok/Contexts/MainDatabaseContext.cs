using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using XMLApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLApp.EntityFramework
{
    public class MainDatabaseContext : DbContext
    {
        public IConfiguration Configuration { get; set; }

        public MainDatabaseContext()
            : base()
        {
            Id = Guid.NewGuid(); 
        }


        public MainDatabaseContext(DbContextOptions<MainDatabaseContext> options)
            : base(options)
        {
            Id = Guid.NewGuid();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLazyLoadingProxies();
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("MainDatabaseContext"));
            }
        }

        public Guid Id { get; set; }

        public static MainDatabaseContext Create()
        {
            return (new AppContextFactory()).CreateDbContext(new string[0]);
        }

        //Add-Migration -Context MainDatabaseContext -o MainDatabaseMigrations <Nazwa migracji>
        //Update-Database -Context MainDatabaseContext
        //Remove-Migration -Context MainDatabaseContext

        #region Core
        public DbSet<AppSetting> AppSettings { get; set; }
        public DbSet<Product> Products { get; set; }
 
        #endregion 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Core

            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            #endregion Core
        }
    }
}
