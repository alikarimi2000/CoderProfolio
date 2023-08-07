using _00.Framework.Infrast;
using CD.ApplicationContracts.ProjectCategory;
using CD.Domain.ProjectCategoryAgg;
using System.Security.Cryptography.X509Certificates;

namespace CD.Infrastructure.Repository
{
    public class ProjectCategoryRepository : RepositoryBase<int,ProjectCategory>, IProjectCategoryRepository
    {
        private readonly EfContext _efContext;

        public ProjectCategoryRepository(EfContext efContext):base(efContext)
        {
            this._efContext = efContext;
        }


        public EditProjectCategory GetDetails(int id)
        {
            return _efContext.ProjectCategories.Select(x => new EditProjectCategory
            {
                Id =x.Id,
                Name = x.Name,
            }).FirstOrDefault(x=>x.Id==id);

        }

      

        public List<ProjectCategoryViewModel> Search(string name)
        {
            var query = _efContext.ProjectCategories.Select(x => new ProjectCategoryViewModel
            {
                Name = x.Name,
                Id = x.Id,
                CreationDate=x.CreationDate.ToLongDateString(),
            });
            if (!string.IsNullOrEmpty(name))
            
            {
                query=query.Where(x => x.Name == name);
            }
            return query.ToList();
        }
    }
}
