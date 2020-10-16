using Cangul.EducationApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.DataAccess.Concrete.EntityFramworkCore.Mapping
{
    public class QuesstionSectionMap : IEntityTypeConfiguration<QuestionSection>
    {

        public void Configure(EntityTypeBuilder<QuestionSection> builder)
        {
            builder.HasKey(eg => new { eg.QuestionId, eg.SectionId });
            builder.HasOne(eg => eg.Question)
                .WithMany(g => g.QuestionSections)
                .HasForeignKey(bc => bc.QuestionId);
            builder.HasOne(bc => bc.Section)
                .WithMany(c => c.QuestionSections)
                .HasForeignKey(bc => bc.SectionId);
        }
    }
}
