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
        Project Get(int Id);

    }
}
