using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSProjectLibrary
{
    [Serializable]
    public class customer : User
    {
        public customer() { }
        public customer(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }
}
