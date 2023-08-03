using _00.Framework.Domain;
using CD.Domain.ProjectCategoryAgg;

namespace CD.Domain.ProjectAgg
{
    public class Project:EntityBase
    {
      
        public string Name { get; private set; }
        public string ShortDescription { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }
        public string File { get; private set; }
         
        public bool IsRemoved { get; private set; }
        public int ProjectCategoriId { get; private set; }
        public ProjectCategory Category { get; private set; }
        public Project(string name, string shortDescription, string description,
            string image, string file, int projectCategoriId)
        {
            Name = name;
            ShortDescription = shortDescription;
            Description = description;
            Image = image;
            File = file;
            IsRemoved = false;
            ProjectCategoriId=projectCategoriId;
        }
        public void Edit(string name, string shortDescription, string description,
            string image, string file)
        {
            Name = name;
            ShortDescription = shortDescription;
            Description = description;
            Image = image;
            File = file;
            IsRemoved = false;
        }
        public void Delete()
        {
            IsRemoved = true;
        }
        public void Restore()
        {
            IsRemoved = false;
        }
    }
}