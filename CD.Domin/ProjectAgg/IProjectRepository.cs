using CD.ApplicationContracts.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Domain.ProjectAgg
{
    public interface IProjectRepository
    {
        void Creat(Project project);
        void SaveChange();
        EditProject GetDetails(int id);
        Project Get(int Id);

    }
}
