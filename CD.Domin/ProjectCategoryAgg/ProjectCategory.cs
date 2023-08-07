using _00.Framework.Application;
using _00.Framework.Domain;
using CD.Domain.ProjectAgg;
using System.ComponentModel.DataAnnotations;

namespace CD.Domain.ProjectCategoryAgg
{
    public class ProjectCategory:EntityBase
    {
        [Required (ErrorMessage =VallidationMesages.IsReq)]
        public string Name { get; private set; }
        = string.Empty;
        public List<Project> Projects { get; set; }
        public ProjectCategory(string name)
        {
            Name = name;
            Projects = new List<Project>();
        }
        public void Edit(string name)
        {
            Name = name;
        }


    }
}