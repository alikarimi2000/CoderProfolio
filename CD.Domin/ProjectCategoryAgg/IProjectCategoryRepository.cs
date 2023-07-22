using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Domain.ProjectCategoryAgg
{
    public interface IProjectCategoryRepository
    {
        ProjectCategory Get(int id);
        void Creat(ProjectCategory projectCategory);

    }
}
