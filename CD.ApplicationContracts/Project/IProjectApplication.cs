using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.ApplicationContracts.Project
{
    public interface IProjectApplication
    {
        void Creat(CreatProject Comand);
        void Edit (EditProject Comand);
        void Remove();
        void Restore();
        EditProject GetDetials (int  Id);
        List<ProjectViewModel> Search (ProjectSearchModel Comand);


    }
}
