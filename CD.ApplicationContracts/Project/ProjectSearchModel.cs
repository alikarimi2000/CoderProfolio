using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.ApplicationContracts.Project
{
    public class ProjectSearchModel
    {
 
        public string Name { get; set; }
        public int ProjectCategoryId { get; set; }
        public bool IsRemoved { get; set; }
    }
}
