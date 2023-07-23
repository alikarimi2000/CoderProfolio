using CD.ApplicationContracts.ProjectCategory;
using CD.Domain.ProjectCategoryAgg;
using System.Security.Cryptography.X509Certificates;

namespace CD.Infrastructure.Repository
{
    public class ProjectCategoryRepository : IProjectCategoryRepository
    {
        private readonly EfContext _efContext;

        public ProjectCategoryRepository(EfContext efContext)
        {
            this._efContext = efContext;
        }

        public void Creat(ProjectCategory projectCategory)
        {

            _efContext.ProjectCategories.Add(projectCategory);
            SaveChange();
        }

        public bool Exist(string name)
        {
            return _efContext.ProjectCategories.Any(c => c.Name == name);
        }

        public ProjectCategory Get(int id)
        {
            return _efContext.ProjectCategories.FirstOrDefault(c => c.Id == id);
        }

        public EditProjectCategory GetDetails(int id)
        {
            return _efContext.ProjectCategories.Select(x => new EditProjectCategory
            {
                Id =x.Id,
                Name = x.Name,
            }).FirstOrDefault(x=>x.Id==id);

        }

        public void SaveChange()
        {
            _efContext.SaveChanges();
        }

        public List<ProjectCategoryViewModel> Search(string name)
        {
            var query = _efContext.ProjectCategories.Select(x => new ProjectCategoryViewModel
            {
                Name = x.Name,
                Id = x.Id,
            });
            if (!string.IsNullOrEmpty(name))
            
            {
                query=query.Where(x => x.Name == name);
            }
            return query.ToList();
        }
    }
}
