using CD.Infrastructure.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CD.UseCase.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List< ProjectQueryViewModel> Projects { get; set; }
        private readonly IProjectQuery projectQuery;
        public IndexModel(ILogger<IndexModel> logger, IProjectQuery projectQuery)
        {
            _logger = logger;
            this.projectQuery = projectQuery;
        }

        public void OnGet()
        {
            Projects = projectQuery.GetAll();

        }
    }
}