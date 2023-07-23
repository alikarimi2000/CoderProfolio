namespace CD.ApplicationContracts.ProjectCategory
{
    public interface IProjectCategoryApplication
    {
        void Creat(CreatProjectCategory command);
        void Edit (EditProjectCategory command);
        List<ProjectCategoryViewModel> GetAll();
        EditProjectCategory GetDetails(int id);

        List<ProjectCategoryViewModel> Search(string name);


         
    }
}