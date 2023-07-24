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
        public void Creat(Project project)
        {
            efContext.Projects.Add(project);
            SaveChange();
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
    }
}
