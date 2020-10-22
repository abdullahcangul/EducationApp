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
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.HasOne(I => I.Test).WithMany(I => I.QuestionTest).HasForeignKey(I => I.TestId);
        }
    }
}
