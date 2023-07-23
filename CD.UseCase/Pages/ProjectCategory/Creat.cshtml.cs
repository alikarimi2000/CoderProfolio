using CD.ApplicationContracts.ProjectCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CD.UseCase.Pages.ProjectCategory
{
    public class CreatModel : PageModel
    {
        private readonly IProjectCategoryApplication projectCategoryApplication;

        public CreatModel(IProjectCategoryApplication projectCategoryApplication)
        {
            this.projectCategoryApplication = projectCategoryApplication;
        }
        public RedirectToPageResult OnPost(CreatProjectCategory project )
        {
            projectCategoryApplication.Creat( project );
            return RedirectToPage("./Index");
        }

        public void OnGet()
        {
        }
    }
}
