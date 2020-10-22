using Cangul.EducationApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.DataAccess.Concrete.EntityFramworkCore.Mapping
{
    public class StudentTestMap : IEntityTypeConfiguration<StudentTest>
    {
        public void Configure(EntityTypeBuilder<StudentTest> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.HasMany(I => I.StudentAnswers).WithOne(I => I.StudentTest).HasForeignKey(I => I.StudentTestId);
        }
    }
}
