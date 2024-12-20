﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace CaloriesCalculator.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new UserConfiguration());

            builder.Entity<Food>()
                .HasKey(f => f.Name);

            builder.Entity<SelectedFood>()
                .HasKey(sf => sf.Id);

            builder.Entity<SelectedFood>()
                .HasOne<Food>()
                .WithMany()
                .HasForeignKey(sf => sf.Name)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Food>()
                .HasOne(f => f.Category)
                .WithMany()
                .HasForeignKey(f => f.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(builder);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<ProgressEntry> ProgressEntries { get; set; }
        public DbSet<SelectedFood> SelectedFoods { get; set; }
        public DbSet<UserSettings> UserSettings { get; set; }
    }
}
