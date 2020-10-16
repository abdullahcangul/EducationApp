using Cangul.EducationApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.DataAccess.Concrete.EntityFramworkCore.Mapping
{
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.HasMany(I => I.Parents).WithOne(I => I.Student).HasForeignKey(I => I.StudentId);
            builder.HasOne(I => I.Person).WithOne(I => I.Student).HasForeignKey<Student>(p => p.PersonId);
            builder.HasOne(I => I.Teacher).WithMany(I => I.Students).HasForeignKey(I => I.TeacherId);
            builder.HasOne(I => I.Classroom).WithMany(I => I.Students).HasForeignKey(I => I.ClassromId);

        }
    }
}
