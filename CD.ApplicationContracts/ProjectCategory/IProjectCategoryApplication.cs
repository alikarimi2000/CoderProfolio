namespace CD.ApplicationContracts.ProjectCategory
{
    public interface IProjectCategoryApplication
    {
        void Creat(CreatProjectCategory command);
        void Edit (EditProjectCategory command);
        List<ProjectViewModel> GetAll();
        List<ProjectViewModel> Search(string name);


         
    }
}