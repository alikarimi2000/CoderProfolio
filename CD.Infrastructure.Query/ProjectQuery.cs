using CD.ApplicationContracts.Project;
using CD.Infrastructure;
using CD.Infrastructure.Repository;

namespace CD.Infrastructure.Query
{
    public class ProjectQuery : IProjectQuery
    {
        private readonly EfContext efContext;

        public ProjectQuery(EfContext efContext)
        {
            this.efContext = efContext;
        }

        public List<ProjectQueryViewModel> GetAll()
        {
            var query = efContext.Projects
           .Join(
               efContext.ProjectCategories,
               p => p.ProjectCategoriId,
               pc => pc.Id,
               (p, pc) => new { Project = p, Category = pc }
           ).Where(p=>p.Project.IsRemoved==false)

           .Select(p => new ProjectQueryViewModel
           {
               Name = p.Project.Name,
               Id = p.Project.Id,
               File = p.Project.File,
               Image = p.Project.Image,
               ShortDescription = p.Project.ShortDescription,
               Description = p.Project.Description,
               CreationDate = p.Project.CreationDate.ToString(),
               Category = p.Category.Name,
               IsRemoved = p.Project.IsRemoved
           })
           .ToList();
            return query;
        }
    }
}
