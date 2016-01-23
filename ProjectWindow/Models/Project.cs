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

        public Project(Member creator, string name, Uri location)
        {
            tasks = new List<Task>();
            artifacts = new List<Artifact>();
            Creator = creator;
        }

        public string Name { get; private set; }
        public Uri Root { get; private set; }
        public Member Creator { get; private set; }
    }

}
