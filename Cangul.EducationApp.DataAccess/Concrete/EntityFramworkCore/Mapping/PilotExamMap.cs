using Cangul.EducationApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.DataAccess.Concrete.EntityFramworkCore.Mapping
{
    public class PilotExamMap : IEntityTypeConfiguration<PilotExam>
    {
        public void Configure(EntityTypeBuilder<PilotExam> builder)
        {

            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.HasMany(I => I.Sections).WithOne(I => I.PilotExam).HasForeignKey(I => I.PilotExamId);

        }
    }
}
