using System;
using System.Collections.Generic;
using System.Linq;
using LstSurveyApi.Models;
using Microsoft.EntityFrameworkCore;


namespace LstSurveyApi.Context
{
    public class OptionContext : DbContext
    {
        public OptionContext(DbContextOptions<OptionContext> options) : base(options)
        { 

        }
        public DbSet<Option> Options { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=37.230.108.246;Database=halk1342_oHalk061020;User ID=skyPeople;Password=pG7@39b@;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Option>()
                .Property(o => o.QuestionId)
                .HasColumnName("question_id");

        }
    }
}
