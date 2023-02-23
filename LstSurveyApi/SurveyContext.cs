using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LstSurveyApi.Models
{
    public class SurveyContext : DbContext
    {
        public SurveyContext(DbContextOptions<SurveyContext> options) : base(options)
        {
        }
        public DbSet<Survey> Surveys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=37.230.108.246;Database=halk1342_oHalk061020;User ID=skyPeople;Password=pG7@39b@;TrustServerCertificate=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuestionUnitSurvey>().HasKey(qus => new { qus.QuestionId, qus.SurveyId });
            modelBuilder.Entity<Survey>().HasKey(qus => new { qus.SurveyId });
            modelBuilder.Entity<Unit>().HasKey(qus => new { qus.UnitId });
            modelBuilder.Entity<Question>().HasKey(qus => new { qus.QuestionId });
            modelBuilder.Entity<SurveyUser>().HasKey(qus => new { qus.UserId });



            modelBuilder.Entity<Survey>()
                .Property(s => s.SurveyId)
                .HasColumnName("survey_id");
                

            modelBuilder.Entity<Survey>()
                .Property(s => s.SurveyName)
                .HasColumnName("survey_name");

            modelBuilder.Entity<Survey>()
                .Property(s => s.SurveyDate)
                .HasColumnName("survey_date");

            modelBuilder.Entity<Survey>()
                .Property(s => s.CreateDate)
                .HasColumnName("create_date");

            modelBuilder.Entity<Survey>()
                .Property(s => s.UpdateDate)
                .HasColumnName("update_date");

            modelBuilder.Entity<Survey>()
                .Property(s => s.CreaterUser)
                .HasColumnName("creater_user");

            modelBuilder.Entity<Survey>()
                .Property(s => s.UpdaterUser)
                .HasColumnName("updater_user");
        }
    }
    public class SurveyService
    {
        private readonly SurveyContext _context;

        public SurveyService(SurveyContext context)
        {
            _context = context;
        }

        public List<Survey> GetSurveys()
        {
            return _context.Surveys.ToList();
        }
    }
}