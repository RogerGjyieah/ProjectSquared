using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Task : AModel
    {
        private Member initiator;
        private List<Member> contributors;

        public Task(string id, Member initiator, bool initIsContributor) : base(id)
        {
            this.initiator = initiator;

            contributors = new List<Member>();

            if (initIsContributor)
            {
                contributors.Add(initiator);
            }
        }
    }
}
