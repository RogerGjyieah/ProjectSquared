using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class AModel
    {
        public AModel(string id)
        {
            ID = id;
        }

        public string ID { get; private set; }
    }
}
