using Cangul.EducationApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.DataAccess.Concrete.EntityFramworkCore.Mapping
{
    public class TrotMap : IEntityTypeConfiguration<Trot>
    {
        public void Configure(EntityTypeBuilder<Trot> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.HasOne(I => I.Group).WithMany(I => I.Trots).HasForeignKey(I => I.GroupId);
            builder.HasOne(I => I.Section).WithOne(I => I.Trot).HasForeignKey<Trot>(I => I.TestId);

        }
    }
}
