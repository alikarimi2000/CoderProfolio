using _00.Framework.Domain;
using CD.ApplicationContracts.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Domain.ProjectAgg
{
    public interface IProjectRepository : IRepository<int, Project>
    {
       
        EditProject GetDetails(int id);
        List<ProjectViewModel> Search(ProjectSearchModel projectSearch);
        List<ProjectViewModel> GetAllProject();

    }
}
