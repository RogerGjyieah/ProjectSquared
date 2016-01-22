using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Member
    {
        public Member(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
        public ContactInfo ContactInfo { get; set; }
    }
}
