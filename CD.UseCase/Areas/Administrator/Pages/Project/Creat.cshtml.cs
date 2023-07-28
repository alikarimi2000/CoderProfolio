using CD.ApplicationContracts.Project;
using CD.ApplicationContracts.ProjectCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CD.UseCase.Areas.Administrator.Pages.Project
{
    public class CreatModel : PageModel
    {
        public List<SelectListItem> ProjectCategories;
        private readonly IProjectApplication projectApplication;
        private readonly IProjectCategoryApplication projectCategoryApplication;
        public int CategoryID;
        public string name { get; set; }

        public CreatModel(IProjectApplication projectApplication,
            IProjectCategoryApplication projectCategoryApplication)
        {
            this.projectApplication = projectApplication;
            this.projectCategoryApplication = projectCategoryApplication;
        }
        public RedirectToPageResult OnPost(CreatProject project)
        {
            projectApplication.Creat(project);
            return RedirectToPage("./Index");
        }

        public void OnGet(int id,string name)
        {
            CategoryID = id;
            if (id== 0)
            {
                ProjectCategories = projectCategoryApplication.Search(name)
                    .Select(x => new SelectListItem(x.Name, x.Id.ToString())).ToList();

            }
            
        }
    }
}
