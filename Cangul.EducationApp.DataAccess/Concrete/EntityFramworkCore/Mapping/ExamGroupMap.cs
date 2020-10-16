using Cangul.EducationApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.DataAccess.Concrete.EntityFramworkCore.Mapping
{
    public class ExamGroupMap : IEntityTypeConfiguration<ExamGroup>
    {
        public void Configure(EntityTypeBuilder<ExamGroup> builder)
        {



            builder.HasKey(eg => new { eg.ExamId, eg.GroupId });
            builder.HasOne(eg => eg.Group)
                .WithMany(g => g.ExamGroups)
                .HasForeignKey(bc => bc.GroupId);
            builder.HasOne(bc => bc.Exam)
                .WithMany(c => c.ExamGroups)
                .HasForeignKey(bc => bc.GroupId);
        }
    }
}
