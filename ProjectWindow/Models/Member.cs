using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Member : AModel
    {
        private List<MemberRole> roles;

        public Member(string id, string name) : base(id)
        {
            Name = name;
            roles = new List<MemberRole>();
        }

        public string Name { get; private set; }
        public ContactInfo ContactInfo { get; set; }
        public MemberRole[] Roles {get {return roles.ToArray();}}

        public void AddRole(MemberRole role)
        {
            if (!IsRole(role))
            {
                roles.Add(role);
            }
        }

        public void RemoveRole(MemberRole role)
        {
            roles.Remove(role);
        }

        public bool IsRole(MemberRole role)
        {
            return roles.Contains(role);
        }
    }
}
