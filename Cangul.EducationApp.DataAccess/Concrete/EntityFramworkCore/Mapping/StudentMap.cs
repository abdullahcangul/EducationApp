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

            builder.Property(I => I.Name).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Surname).HasMaxLength(100).IsRequired();
            builder.Property(I => I.StudentNumber).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Tel).HasMaxLength(20).IsRequired();
            builder.Property(I => I.ParentTel).HasMaxLength(20).IsRequired();

            builder.HasMany(I => I.studentTests).WithOne(I => I.Student).HasForeignKey(I => I.StudentID);
        }
    }
}
