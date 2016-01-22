using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Task
    {
        private Member initiator;
        private List<Member> contributors;

        public Task(Member initiator, bool initIsContributor)
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
