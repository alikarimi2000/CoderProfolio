﻿using CD.ApplicationContracts.ProjectCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD.ApplicationContracts.Project
{
    public class CreatProject
    {
        public  int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string Image { get; set; }
        public string File { get; set; }
       public List<ProjectCategoryViewModel>ProjectCategories { get; set; }

    }
}
