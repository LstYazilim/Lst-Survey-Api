using System;
using System.Collections.Generic;
using System.Linq;
using LstSurveyApi.Models;
using Microsoft.EntityFrameworkCore;


namespace LstSurveyApi.Context
{
    public class QuestionContext : DbContext
    {
        public QuestionContext(DbContextOptions<QuestionContext> options) : base(options) 
        { 
        
        }

        public DbSet<Question> Question { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=37.230.108.246;Database=halk1342_oHalk061020;User ID=skyPeople;Password=pG7@39b@;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Question>()
                .Property(s => s.QuestionId)
                .HasColumnName("question_id");


            modelBuilder.Entity<Question>()
                .Property(s => s.QuestionText)
                .HasColumnName("question_text");

            modelBuilder.Entity<Question>()
                .Property(s => s.CreateDate)
                .HasColumnName("create_date");

            modelBuilder.Entity<Question>()
                .Property(s => s.UpdateDate)
                .HasColumnName("update_date");

            modelBuilder.Entity<Question>()
                .Property(s => s.CreaterUser)
                .HasColumnName("creater_user");

            modelBuilder.Entity<Question>()
                .Property(s => s.UpdaterUser)
                .HasColumnName("updater_user");

            

        }
    }
}
