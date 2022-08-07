using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSProjectLibrary
{
    [Serializable]
    
    public class task
    {
        //public customer() { }

        private Guid taskId;
        private string name;
        private Status status;

        public Guid TaskId
        {
            get { return taskId; }
            set { taskId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Status theStatus
        {
            get { return status; }
            set { status = value; }
        }

        public task(Guid id, string name, Status status)
        {
            this.taskId = id;
            this.name = name;
            this.status = status;
        }
        public string NameAndStatus
        {
            get { return name + " - " + status; }
        }
    }
}
