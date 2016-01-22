using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Project
    {
        private List<Task> tasks;
        private List<Artifact> artifacts;

        public Project(string name, Uri location)
        {
            tasks = new List<Task>();
            artifacts = new List<Artifact>();
        }

        public string Name { get; private set; }
        public Uri Root { get; private set; }
    }

}
