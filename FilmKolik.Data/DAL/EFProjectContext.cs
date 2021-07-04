using Filmkolik.Entities.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmkolik.Data.DAL
{
    public class EFProjectContext : DbContext
    {
        public EFProjectContext(DbContextOptions<EFProjectContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<FilmDetail> FilmDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    ID = 1,
                    Username = "admin",
                    Password = "admin",
                    CreatedDate = DateTime.Now,
                    FirstName = "admin",
                    LastName = "user",
                    Rol = Enums.Roller.Admin
                },
                new User
                {
                    ID = 2,
                    Username = "film",
                    Password = "user",
                    CreatedDate = DateTime.Now,
                    FirstName = "film",
                    LastName = "user",
                    Rol = Enums.Roller.FilmUser
                },
                new User
                {
                    ID = 3,
                    Username = "star",
                    Password = "user",
                    CreatedDate = DateTime.Now,
                    FirstName = "film",
                    LastName = "user",
                    Rol = Enums.Roller.StarUser
                }
                );
        }
    }
}
