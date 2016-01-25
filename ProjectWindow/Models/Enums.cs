using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public enum TeamRole
    {
        Development,
        Test,
        Design
    }

    [Serializable]
    public enum MemberRole
    {
        Creator,
        Reader,
        Writer,
        Contributor,
        Manager
    }
}
