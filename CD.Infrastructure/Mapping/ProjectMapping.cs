using CD.Domain.ProjectAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Infrastructure.Mapping
{
    public class ProjectMapping : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Projects");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).HasMaxLength(256).IsRequired();
            builder.HasOne(x => x.Category).WithMany(x => x.Projects).
                HasForeignKey(x=>x.ProjectCategoriId);

        }
    }
}
