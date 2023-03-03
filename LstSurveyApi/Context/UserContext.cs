using System;
using System.Collections.Generic;
using System.Linq;
using LstSurveyApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LstSurveyApi.Context
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
        public DbSet<SurveyUser> SurveyUser { get; set;} 

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=37.230.108.246;Database=halk1342_oHalk061020;User ID=skyPeople;Password=pG7@39b@;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SurveyUser>()
                .Property(e => e.UserId)
                .HasColumnName("user_id");

            modelBuilder.Entity<SurveyUser>()
                .Property (e => e.UserName)
                .HasColumnName("user_name");

            modelBuilder.Entity<SurveyUser>()
                .Property(e => e.UserPassword)
                .HasColumnName("user_password");

            modelBuilder.Entity<SurveyUser>()
                .Property(e => e.SurveyId)
                .HasColumnName ("survey_id");
        }
           
    }
}
