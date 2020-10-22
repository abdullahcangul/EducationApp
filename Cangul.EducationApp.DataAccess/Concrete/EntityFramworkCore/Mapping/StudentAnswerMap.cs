using Cangul.EducationApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cangul.EducationApp.DataAccess.Concrete.EntityFramworkCore.Mapping
{
    class StudentAnswerMap : IEntityTypeConfiguration<StudentAnswer>
    {
        public void Configure(EntityTypeBuilder<StudentAnswer> builder)
        {

            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();
        }
    }
}
