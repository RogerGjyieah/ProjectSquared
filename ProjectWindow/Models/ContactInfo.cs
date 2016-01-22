using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ContactInfo
    {
        private List<Alias> aliases;

        public ContactInfo(string email, string phonenumber)
        {
            Email = email;
            PhoneNumber = phonenumber;
            aliases = new List<Alias>();
        }

        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }

        public List<Alias> GetAliases()
        {
            return aliases;
        }

    }
}
