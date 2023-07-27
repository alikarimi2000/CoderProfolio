using CD.ApplicationContracts.ProjectCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CD.UseCase.Pages
{
    public class ProjectCategoryModel : PageModel
    {
        public List<ProjectCategoryViewModel> projectCategoryViewModels { get; set; }
        private readonly IProjectCategoryApplication projectCategoryApplication;

        public ProjectCategoryModel(IProjectCategoryApplication projectCategoryApplication)
        {
            this.projectCategoryApplication = projectCategoryApplication;
        }

        public void OnGet(string name)
        {
            projectCategoryViewModels = projectCategoryApplication.Search(name);
        }
    }
}
