using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class TradeMonitoringContext : DbContext
    {

        //protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        //{
        //    base.ConfigureConventions(configurationBuilder);
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=TradeMonitoring;user id=sa;password=123456;Trusted_Connection=true;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            modelBuilder.Entity<Role>().HasData(new Role

            {
                IsActive = true,
                CreateDate = DateTime.Now,
                Description = "admin",
                Name = "admin",
                Id = 1
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                CreateDate = DateTime.Now,
                Email = "admin@gmail.com",
                IsActive = true,
                Password = "123456",
                UserName = "admin",
                Id = 1
            });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<RoleAceessMenuMap> RoleAceessMenuMaps { get; set; }
        public DbSet<AccessMenu> AccessMenus { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<UserInRole> UserInRoles { get; set; }

    }
}
