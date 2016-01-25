using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Project : AModel
    {
        private List<Task> tasks;
        private List<Artifact> artifacts;

        public Project(string id, Member creator, string name, Uri location) : base(id)
        {
            tasks = new List<Task>();
            artifacts = new List<Artifact>();
            Creator = creator;
            Name = name;
            Root = location;
        }

        public string Name { get; private set; }
        public Uri Root { get; private set; }
        public Member Creator { get; private set; }
    }

}
