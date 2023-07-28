using CD.Application;
using CD.ApplicationContracts.Project;
using CD.ApplicationContracts.ProjectCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CD.UseCase.Areas.Administrator.Pages.Project
{
    public class EditModel : PageModel
    {
        private readonly IProjectApplication projectApplication;
        public EditProject editProject;

        public EditModel(IProjectApplication projectApplication)
        {
            this.projectApplication = projectApplication;
        }

        public void OnGet(int id)
        {
            editProject=projectApplication.GetDetials(id);
            projectApplication.GetDetials(id);
        }
        public RedirectToPageResult OnPost(EditProject editProject)
        {
            projectApplication.Edit(editProject);
            return RedirectToPage("./Index");
        }
    }
}
