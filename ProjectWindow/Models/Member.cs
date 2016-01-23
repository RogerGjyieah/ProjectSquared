using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Member
    {
        private List<MemberRole> roles;

        public Member(string name)
        {
            Name = name;
            roles = new List<MemberRole>();
        }

        public string Name { get; private set; }
        public ContactInfo ContactInfo { get; set; }

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

        public MemberRole[] GetRoles()
        {
            return roles.ToArray();
        }
    }
}
