using CD.Domain.ProjectCategoryAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CD.Infrastructure.Mapping
{
    internal class ProjectCategoryMapping : IEntityTypeConfiguration<ProjectCategory>
    {
        public void Configure(EntityTypeBuilder<ProjectCategory> builder)
        {
            builder.ToTable("ProjectCategories");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Name).HasMaxLength(255).IsRequired();

            builder.HasMany(x => x.Projects).WithOne(x => x.Category).HasForeignKey(x => x.ProjectCategoriId);
                
        }
    }
}
