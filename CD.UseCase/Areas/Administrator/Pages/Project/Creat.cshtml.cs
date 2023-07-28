using CD.ApplicationContracts.Project;
using CD.ApplicationContracts.ProjectCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CD.UseCase.Areas.Administrator.Pages.Project
{
    public class CreatModel : PageModel
    {
        private readonly IProjectApplication projectApplication;
        public int CategoryID;
        public string name { get; set; }

        public CreatModel(IProjectApplication projectApplication)
        {
            this.projectApplication = projectApplication;
        }
        public RedirectToPageResult OnPost(CreatProject project)
        {
            projectApplication.Creat(project);
            return RedirectToPage("./Index");
        }

        public void OnGet(int id,string name)
        {
            CategoryID = id;
            this.name = name;
        }
    }
}
