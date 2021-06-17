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
    }
}
