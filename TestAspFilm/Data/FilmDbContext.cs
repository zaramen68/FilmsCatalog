using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAspFilm.Models;

namespace TestAspFilm.Data
{
    public class FilmDbContext:DbContext
    {
        public FilmDbContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-FilmsCatalog-0248253E-E432-4B2A-B3BF-C06124FFFBA2;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<Film> Films
        {
            get; set;
        }
        public DbSet<User> Users
        {
            get; set;
        }
    }
}
