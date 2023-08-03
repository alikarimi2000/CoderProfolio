using _00.Framework.Domain;
using CD.ApplicationContracts.ProjectCategory;


namespace CD.Domain.ProjectCategoryAgg
{
    public interface IProjectCategoryRepository:IRepository<int,ProjectCategory>

    {
        EditProjectCategory GetDetails(int id);
        List<ProjectCategoryViewModel> Search(string name);
       

    }
}
