using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using FilmsCatalog.Models;

namespace FilmsCatalog.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        /*
        public ApplicationDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-FilmsCatalog-0248253E-E432-4B2A-B3BF-C06124FFFBA2;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        */

        public DbSet<Film> Films { get; set; }
        public DbSet<FileModel> Files { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<Film>().ToTable("Film");
            modelBuilder.Entity<Film>().Property(p => p.Poster).HasColumnType("varbinary(max)");
            base.OnModelCreating(modelBuilder);
            /*
             modelBuilder.Entity<Building>(e =>
             {
                 e.HasKey(p => p.Id);
                 e.Property(p => p.Id).UseIdentityColumn<int>();
                 e.Property(p => p.Address).IsRequired(false).HasColumnType<string>("nvarchar(128)");
                 e.Property(p => p.ApplicationUserId).IsRequired(true);
             });
            */
            /*
            modelBuilder.Entity<Film>()
                .HasOne(e => e.User)
                .WithMany(p => p.Films)
                .HasForeignKey(p => p.UserId);
            */

        }
        
    }
}
