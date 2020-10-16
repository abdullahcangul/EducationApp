using Cangul.EducationApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.DataAccess.Concrete.EntityFramworkCore.Mapping
{
    public class StudentTrotMap : IEntityTypeConfiguration<StudentTrot>
    {
        public void Configure(EntityTypeBuilder<StudentTrot> builder)
        {

            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.HasMany(I => I.Answers).WithOne(I => I.StudentTrot).HasForeignKey(I => I.StudentTrotId);
            builder.HasOne(I => I.Student).WithMany(I => I.StudentTrots).HasForeignKey(I => I.StudentId);
        }
    }
}
