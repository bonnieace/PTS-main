using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSProjectLibrary
{
    [Serializable]
    public class teamleader : User
    {
        //public customer() { }

        private int teamId;

        public int TeamId
        {
            get { return teamId; }
            set { teamId = value; }
        }

        public teamleader(string name, int id, int teamId)
        {
            this.name = name;
            this.id = id;
            this.teamId = teamId;
        }
    }
}
