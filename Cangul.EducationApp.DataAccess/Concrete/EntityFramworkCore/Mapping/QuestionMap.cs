using Cangul.EducationApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.DataAccess.Concrete.EntityFramworkCore.Mapping
{
    public class QuestionMap : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.HasMany(I => I.Images).WithOne(I => I.Question).HasForeignKey(I => I.QuestionId);
            builder.HasOne(I => I.Answer).WithOne(I=>I.AnswerQuestion).HasForeignKey<Question>(I=>I.AnswerId).OnDelete(DeleteBehavior.Restrict); 
            builder.HasMany(I => I.Options).WithOne(I => I.Question).HasForeignKey(I => I.QuestionId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(I => I.QuestionTests).WithOne(I => I.Question).HasForeignKey(I => I.QuestionId);

        }
    }
}
