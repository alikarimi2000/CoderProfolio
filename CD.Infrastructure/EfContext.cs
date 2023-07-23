using CD.Domain.ProjectAgg;
using CD.Domain.ProjectCategoryAgg;
using CD.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace CD.Infrastructure
{
    public class EfContext:DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectCategory> ProjectCategories { get; set; }
        public EfContext(DbContextOptions<EfContext> options) : base(options)
        {

        }
        public EfContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.ApplyConfiguration(new ProjectCategoryMapping());
            modelBuilder.ApplyConfiguration(new ProjectMapping());


            base.OnModelCreating(modelBuilder);
        }
    }
}