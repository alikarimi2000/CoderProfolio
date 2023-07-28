using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.Infrastructure.Query
{
    public interface IProjectQuery
    {
        List<ProjectQueryViewModel> GetAll();

    }
}
