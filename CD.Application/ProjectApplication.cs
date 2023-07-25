using CD.ApplicationContracts.Project;
using CD.Domain.ProjectAgg;


namespace CD.Application
{
    public class ProjectApplication : IProjectApplication
    {
        private readonly IProjectRepository _repository;

        public ProjectApplication(IProjectRepository repository)
        {
            _repository = repository;
        }

        public void Creat(CreatProject Comand)
        {
           if (_repository.Exisit(Comand.Name, Comand.CategoryId))
            {
                return;
            }
           var project=new Project(Comand.Name,Comand.ShortDescription,Comand.Description,
               Comand.Image, Comand.File, Comand.CategoryId);
            _repository.Creat(project);
            _repository.SaveChange();

        }

        public void Edit(EditProject Comand)
        {
            var project=_repository.Get(Comand.Id);
            if (project != null)
            {
                project.Edit(Comand.Name, Comand.ShortDescription, Comand.Description, Comand.Image, Comand.File);
                _repository.SaveChange();
            }
        }

        public EditProject GetDetials(int Id)
        {
          return  _repository.GetDetails(Id);
        }

        

        public void Remove(int id)
        {
            var project = _repository.Get(id);
            if (project != null)
            {
                project.Delete();
                _repository.SaveChange();
            }
        }

        public void Restore(int id)
        {
            var project = _repository.Get(id);
            if (project != null)
            {
                project.Delete();
                _repository.SaveChange();
            }
        }

        public List<ProjectViewModel> Search(ProjectSearchModel Comand)
        {
            return _repository.Search(Comand);
        }
    }
}
