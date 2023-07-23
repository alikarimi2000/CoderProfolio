using CD.ApplicationContracts.ProjectCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Domain.ProjectCategoryAgg
{
    public interface IProjectCategoryRepository

    {
        EditProjectCategory GetDetails(int id);
        ProjectCategory Get(int id);
        void Creat(ProjectCategory projectCategory);
        void SaveChange();
        List<ProjectCategoryViewModel> Search(string name);
        bool Exist(string name);

    }
}
