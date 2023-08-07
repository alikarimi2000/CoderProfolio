using CD.ApplicationContracts.ProjectCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CD.UseCase.Areas.Administrator
{
    public class ProjectCategoryModel : PageModel
    {
        public string name { get; set; }
        public EditProjectCategory editProjectCategory { get; set; }
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
        public IActionResult OnGetCreate()
        {
            return Partial("./Create", new CreatProjectCategory());
        }
        public JsonResult OnPostCreate(CreatProjectCategory command)
        {
             projectCategoryApplication.Creat(command);
            return new JsonResult("???");
        }
        public IActionResult OnGetEdit(int id)
        {
            editProjectCategory = projectCategoryApplication.GetDetails(id);
            return Partial("./Edit", editProjectCategory);
        }
    }
}
