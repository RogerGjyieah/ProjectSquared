using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Team : AModel
    {
        private List<Member> members;
        public Team(string id) : base(id)
        {
            members = new List<Member>();
        }

        public Member[] GetMembers()
        {
            return members.ToArray();
        }
    }
}
