using _00.Framework.Domain;
using CD.Domain.ProjectAgg;

namespace CD.Domain.ProjectCategoryAgg
{
    public class ProjectCategory:EntityBase
    {
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