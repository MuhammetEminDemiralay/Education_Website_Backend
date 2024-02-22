using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class EducationContext : DbContext
    {

        public DbSet<Education> Educations { get; set; }
        public DbSet<EducationCategory> EducationCategories { get; set; }
        public DbSet<EducationCategoryImage> EducationCategoryImage { get; set; }
        public DbSet<EducationImage> EducationImages { get; set; }
        public DbSet<EducationSubCategory> EducationSubCategories { get; set; }
        public DbSet<EducationSubCategoryImage> EducationSubCategoryImages { get; set; }
        public DbSet<EducationVideo> EducationVideos { get; set; }
        public DbSet<FrequentlyAskedQuestion> FrequentlyAskedQuestions { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<UserEducation> UserEducations { get; set; }
        public DbSet<VideoSubTitle> VideoSubTitles { get; set; }
        public DbSet<VideoTitle> VideoTitle { get; set; }

        public DbSet<EducationObjective> EducationObjectives { get; set; }
        public DbSet<EducationSummary> EducationSummaries { get; set; }
        public DbSet<EducationTargetAudience> EducationTargetAudinces { get; set; }
        public DbSet<EducationRequirement> EducationRequirements { get; set; }
        public DbSet<EducationAchievement> EducationAchievements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;database=Education;");
        }
    }
}
