using Cangul.EducationApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.DataAccess.Concrete.EntityFramworkCore.Mapping
{

    public class ExamMap : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.HasOne(I => I.Test).WithOne(I => I.Exam).HasForeignKey<Test>(p => p.ExamId);
            builder.HasOne(I => I.PilotExam).WithOne(I => I.Exam).HasForeignKey<PilotExam>(p => p.ExamId);
            builder.HasMany(I => I.StudentTrots).WithOne(I => I.Exam).HasForeignKey(I => I.ExamId);
        }
    }
}
