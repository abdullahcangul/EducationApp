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

            modelBuilder.ApplyConfiguration(new AnswerMap());
            modelBuilder.ApplyConfiguration(new ExamGroupMap());
            modelBuilder.ApplyConfiguration(new ExamMap());
            modelBuilder.ApplyConfiguration(new GroupMap());
            modelBuilder.ApplyConfiguration(new OptionMap());
            modelBuilder.ApplyConfiguration(new ParentMap());
            modelBuilder.ApplyConfiguration(new PersonMap());
            modelBuilder.ApplyConfiguration(new PilotExamMap());
            modelBuilder.ApplyConfiguration(new QuesstionSectionMap());
            modelBuilder.ApplyConfiguration(new QuestionMap());
            modelBuilder.ApplyConfiguration(new QuestionTestMap());
            modelBuilder.ApplyConfiguration(new StudentMap());
            modelBuilder.ApplyConfiguration(new StudentTrotMap());
            modelBuilder.ApplyConfiguration(new TeacherMap());
            modelBuilder.ApplyConfiguration(new TestMap());
            modelBuilder.ApplyConfiguration(new TrotMap());


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Answer> Answer { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<Classroom> Classroom { get; set; }
        public DbSet<DifficultyLevel> DifficultyLevel { get; set; }
        public DbSet<Exam> Exam { get; set; }
        public DbSet<ExamGroup> ExamGroup { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<Option> Option { get; set; }
        public DbSet<Parent> Parent { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<PilotExam> PilotExam { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<QuestionSection> QuestionSection { get; set; }
        public DbSet<QuestionTest> QuestionTest { get; set; }
        public DbSet<Section> Section { get; set; }
        public DbSet<Student> student { get; set; }
        public DbSet<StudentAnswer> StudentAnswer { get; set; }
        public DbSet<StudentTrot> StudentTrot { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Test> Test { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<Trot> Trot { get; set; }

    }
}
