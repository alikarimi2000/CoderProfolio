using CD.ApplicationContracts.Project;
using CD.ApplicationContracts.ProjectCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CD.UseCase.Areas.Administrator.Pages.Project
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
            projectViewModels = projectApplication.Search(searchModel);

        }
        public IActionResult OnGetRemove(int id)
        {
            projectApplication.Remove(id);
            return RedirectToPage("./Index");

        }
        public IActionResult OnGetRestore(int id)
        {
            projectApplication.Restore(id);
            return RedirectToPage("./Index");

        }
    }
}
