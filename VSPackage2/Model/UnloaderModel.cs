using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company.VSPackage2.Model
{
    public class UnloaderModel
    {
        public IList<ProjectModel> Projects { get; set; }        
    }

    public class ProjectModel
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public IList<string> ProjectReferences { get; set; }
        public IList<string> UnloadedDllReferences { get; set; }
    }
}
