using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSProjectLibrary
{
    [Serializable]
    public class team
    {
        //public customer() { }

        private int id;
        private string location;
        private string name;
        private teamleader leader;

        public int TeamId
        {
            get { return id; }
            set { id = value; }
        }

        public teamleader Leader
        {
            get { return leader; }
            set { leader = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public team(int id, string location, string name, teamleader leader)
        {
            this.location = location;
            this.name = name;
            this.id = id;
            this.leader = leader;
        }
    }
}
