using CD.ApplicationContracts.Project;
using CD.Domain.ProjectAgg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Infrastructure.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly EfContext efContext;

        public ProjectRepository(EfContext efContext)
        {
            this.efContext = efContext;
        }

        public void Creat(Project project)
        {
            efContext.Projects.Add(project);
            SaveChange();
        }

        public bool Exisit(string name, int categoryId)
        {
            return efContext.Projects.Any(x=>x.Name==name && x.ProjectCategoriId==categoryId);
        }

        public Project Get(int Id)
        {
           return efContext.Projects.FirstOrDefault(p => p.Id == Id);
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

        public void SaveChange()
        {
             efContext.SaveChanges();
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
                .Where(p => !p.Project.IsRemoved)
                .Select(p => new ProjectViewModel
                {
                    Name = p.Project.Name,
                    Id=p.Project.Id,
                    File = p.Project.File,
                    Image = p.Project.Image,
                    ShortDescription = p.Project.ShortDescription,
                    Description = p.Project.Description,
                    CreationDate = p.Project.CreationDate.ToString(),
                    Category = p.Category.Name
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
