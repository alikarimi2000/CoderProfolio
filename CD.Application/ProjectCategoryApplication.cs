using CD.ApplicationContracts.ProjectCategory;
using CD.Domain.ProjectCategoryAgg;

namespace CD.Application
{
    public class ProjectCategoryApplication : IProjectCategoryApplication
    {
        private readonly IProjectCategoryRepository projectCategoryRepository;

        public ProjectCategoryApplication(IProjectCategoryRepository projectCategoryRepository)
        {
            this.projectCategoryRepository = projectCategoryRepository;
        }

        public void Creat(CreatProjectCategory command)
        {
            if (projectCategoryRepository.Exisit(x=>x.Name==command.Name))
            {
                return;
            }
            var projectCategory = new ProjectCategory(command.Name);
            projectCategoryRepository.Creat(projectCategory);
            projectCategoryRepository.SaveChange(); 


        }

        public void Edit(EditProjectCategory command)
        {
            var projectCategory = projectCategoryRepository.Get(command.Id);
            if (projectCategory == null)
            {
                return;
            }
            projectCategory.Edit(command.Name);
            projectCategoryRepository.SaveChange();

        }

        public List<ProjectCategoryViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public EditProjectCategory GetDetails(int id)
        {
            return projectCategoryRepository.GetDetails(id);
        }

        public List<ProjectCategoryViewModel> Search(string name)
        {
            return projectCategoryRepository.Search(name);
        }
    }
}