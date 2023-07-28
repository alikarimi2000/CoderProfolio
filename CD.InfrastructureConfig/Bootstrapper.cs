using CD.Application;
using CD.ApplicationContracts.Project;
using CD.ApplicationContracts.ProjectCategory;
using CD.Domain.ProjectAgg;
using CD.Domain.ProjectCategoryAgg;
using CD.Infrastructure;
using CD.Infrastructure.Query;
using CD.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CD.InfrastructureConfig
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddMyDependencyGroup(
             this IServiceCollection services)
        {
            services.AddTransient<IProjectCategoryApplication, ProjectCategoryApplication>();
            services.AddTransient<IProjectCategoryApplication, ProjectCategoryApplication>();
            services.AddTransient<IProjectCategoryRepository, ProjectCategoryRepository>();
            services.AddTransient<IProjectApplication, ProjectApplication>();
            services.AddTransient<IProjectRepository, ProjectRepository>();
            services.AddTransient<IProjectQuery, ProjectQuery>();
            var connectionString = "Server=.;Database=Profolio;Trusted_Connection=True;TrustServerCertificate=True;User Id=DESKTOP-IT7PIRM\\ali;";
            services.AddDbContext<EfContext>(x => x.UseSqlServer(connectionString));
            return services;
        }
    }
}