using Cangul.EducationApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.DataAccess.Concrete.EntityFramworkCore.Mapping
{
    public class QuestionTestMap : IEntityTypeConfiguration<QuestionTest>
    {
        public void Configure(EntityTypeBuilder<QuestionTest> builder)
        {
            builder.HasKey(qt => new { qt.TestId, qt.QuestionId });
            builder.HasOne(qt => qt.Question)
                .WithMany(q => q.QuestionTest)
                .HasForeignKey(qt => qt.QuestionId);
            builder.HasOne(qt => qt.Test)
                .WithMany(t => t.QuestionTest)
                .HasForeignKey(qt => qt.QuestionId);
        }
    }
}
