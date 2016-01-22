using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Alias
    {
        public Alias(string username, Uri forum, string description)
        {
            Username = username;
            Forum = forum;
            Description = description;
        }

        public string Username { get; private set; }
        public Uri Forum { get; private set; }
        public string Description { get; private set; }
    }
}
