using Cangul.EducationApp.DataAccess.Concrete.EntityFramworkCore.Mapping;
using Cangul.EducationApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.DataAccess.Concrete.EntityFramworkCore.Context
{
    public class EducationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=EducationDB;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new OptionMap());
            modelBuilder.ApplyConfiguration(new QuestionMap());
            modelBuilder.ApplyConfiguration(new QuestionTestMap());
            modelBuilder.ApplyConfiguration(new StudentAnswerMap());
            modelBuilder.ApplyConfiguration(new StudentMap());
            modelBuilder.ApplyConfiguration(new StudentTestMap());
            modelBuilder.ApplyConfiguration(new TestMap());


            base.OnModelCreating(modelBuilder);
        }
        
        public DbSet<Image> Image { get; set; }
        public DbSet<Option> Option { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<QuestionTest> QuestionTest { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<StudentAnswer> StudentAnswer { get; set; }
        public DbSet<StudentTest> StudentTest { get; set; }
        public DbSet<Test> Test { get; set; }
        public DbSet<Topic> Topic { get; set; }

    }
}
