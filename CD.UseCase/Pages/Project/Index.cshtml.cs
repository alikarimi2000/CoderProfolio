using CD.ApplicationContracts.Project;
using CD.ApplicationContracts.ProjectCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CD.UseCase.Pages.Project
{
    public class IndexModel : PageModel
    {
        public List<ProjectViewModel> projectViewModels { get; set; }
        private readonly IProjectApplication projectApplication;

        public IndexModel(IProjectApplication projectApplication)
        {
            this.projectApplication = projectApplication;
        }

        public void OnGet(ProjectSearchModel searchModel)
        {
            projectViewModels = projectApplication.Search(searchModel);
            
        }
        public IActionResult OnGetRemove(int id, ProjectSearchModel searchModel)
        {
            projectApplication.Remove(id);
            return RedirectToPage("./Index");

        }
    }
}
