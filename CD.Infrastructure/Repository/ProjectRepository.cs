using _00.Framework.Infrast;
using CD.ApplicationContracts.Project;
using CD.Domain.ProjectAgg;

namespace CD.Infrastructure.Repository
{
    public class ProjectRepository : RepositoryBase<int, Project>, IProjectRepository
    {
        private readonly EfContext efContext;

        public ProjectRepository(EfContext efContext):base(efContext)
        {
            this.efContext = efContext;
        }

        public List<ProjectViewModel> GetAllProject()
        {
            return efContext.Projects.Select(p=>new ProjectViewModel
            {
                Id = p.Id,
                Name = p.Name,
                File = p.File,
                Image = p.Image,
                ShortDescription = p.ShortDescription,
                Description = p.Description,

            }).ToList();
        }

        public EditProject GetDetails(int id)
        {
            return efContext.Projects.Select(p => new EditProject { 
                Id = p.Id,
                Name = p.Name,
                File = p.File,
                Image = p.Image,
                ShortDescription = p.ShortDescription,
                Description = p.Description,

            }).FirstOrDefault(p => p.Id == id);
        }

    

        public List<ProjectViewModel> Search(ProjectSearchModel projectSearch)
        {
        
            var query = efContext.Projects
                .Join(
                    efContext.ProjectCategories,
                    p => p.ProjectCategoriId,
                    pc => pc.Id,
                    (p, pc) => new { Project = p, Category = pc }
                )
                
                .Select(p => new ProjectViewModel
                {
                    Name = p.Project.Name,
                    Id=p.Project.Id,
                    File = p.Project.File,
                    Image = p.Project.Image,
                    ShortDescription = p.Project.ShortDescription,
                    Description = p.Project.Description,
                    CreationDate = p.Project.CreationDate.ToString(),
                    Category = p.Category.Name,
                    IsRemoved=p.Project.IsRemoved
                })
                .ToList();

            if (!string.IsNullOrWhiteSpace(projectSearch.Name))
            {
                query = query.Where(x => x.Name.Contains(projectSearch.Name)).ToList();
            }

            return query;
        }


    }
}
