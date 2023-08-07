using CD.ApplicationContracts.Project;
using CD.ApplicationContracts.ProjectCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CD.UseCase.Areas.Administrator
{
    public class ProjectModel : PageModel
    {
        public SelectList selectList { get; set; }
        public ProjectSearchModel searchModel;
        public EditProject editProject{ get; set; }
        public List<ProjectViewModel> projectViewModels { get; set; }
        private readonly IProjectApplication projectApplication;
        private readonly IProjectCategoryApplication projectCategoryApplication;

        public ProjectModel(IProjectApplication projectApplication, IProjectCategoryApplication projectCategoryApplication)
        {
            this.projectApplication = projectApplication;
            this.projectCategoryApplication = projectCategoryApplication;
        }

        public void OnGet(ProjectSearchModel searchModel)
        {
            selectList = new SelectList(projectCategoryApplication.GetAllPC(), "Id", "Name");
            projectViewModels = projectApplication.Search(searchModel);
        }
        public IActionResult OnGetCreate()
        {
            var comand = new CreatProject
            {
               ProjectCategories = projectCategoryApplication.GetAllPC(),
            };
            return Partial("./Create", comand);
        }
        public JsonResult OnPostCreate(CreatProject command)
        {
             projectApplication.Creat(command);
            return new JsonResult("???");
        }
        public IActionResult OnGetEdit(int id)
        {
            editProject = projectApplication.GetDetials(id);
            return Partial("./Edit", editProject);
        }
        public JsonResult OnPostEdit(EditProject command)
        {
            projectApplication.Edit(command);
            return new JsonResult("???");
        }
    }
}
