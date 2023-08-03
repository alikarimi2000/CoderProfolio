using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.ApplicationContracts.Project
{
    public interface IProjectApplication
    {
        List<ProjectViewModel> GetAllProject();
        void Creat(CreatProject Comand);
        void Edit (EditProject Comand);
        void Remove(int id);
        void Restore(int id);
        EditProject GetDetials (int  Id);
        List<ProjectViewModel> Search (ProjectSearchModel Comand);


    }
}
