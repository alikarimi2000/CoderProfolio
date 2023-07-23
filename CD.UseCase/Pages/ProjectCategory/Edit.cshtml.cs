using CD.ApplicationContracts.ProjectCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CD.UseCase.Pages.ProjectCategory
{
    public class EditModel : PageModel
    {
        public EditProjectCategory editProjectCategory;
        private readonly IProjectCategoryApplication projectCategoryApplication;

        public EditModel(IProjectCategoryApplication projectCategoryApplication)
        {
            this.projectCategoryApplication = projectCategoryApplication;
        }

        public void OnGet(int id)
        {
            editProjectCategory=projectCategoryApplication.GetDetails(id);
        }
        public RedirectToPageResult OnPost(EditProjectCategory editProjectCategory) 
        {
            projectCategoryApplication.Edit(editProjectCategory);
            return RedirectToPage("./Index");
        }
    }
}
