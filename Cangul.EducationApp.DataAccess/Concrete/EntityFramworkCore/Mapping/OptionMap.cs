using Cangul.EducationApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.DataAccess.Concrete.EntityFramworkCore.Mapping
{
    public class OptionMap : IEntityTypeConfiguration<Option>
    {
        public void Configure(EntityTypeBuilder<Option> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.Content).HasMaxLength(500).IsRequired();
            builder.Property(I => I.Description).HasMaxLength(500);

           builder.HasOne(I=>I.AnswerQuestion).WithOne(I => I.Answer).HasForeignKey<Question>(I=>I.AnswerId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
