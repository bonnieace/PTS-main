using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSProjectLibrary
{
    [Serializable]
    public class project
    {
        //public customer() { }

        private string name;
        private DateTime expectedStartDate;
        private DateTime expectedEndDate;
        private customer theCustomer;
        private Guid projectId;
        private List<task> tasks;

        public List<task> Tasks
        {
            get { return tasks; }
            set { tasks = value; }
        }
        public customer TheCustomer
        {
            get { return theCustomer; }
            set { theCustomer = value; }
        }
        public Guid ProjectId
        {
            get { return projectId; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime ExpectedStartDate
        {
            get { return expectedStartDate; }
            set { expectedStartDate = value; }
        }
        public DateTime ExpectedEndDate
        {
            get { return expectedEndDate; }
            set { expectedEndDate = value; }
        }

        public project(string name, DateTime startDate, DateTime endDate, Guid projectId, List<task> tasks)
        {
            this.name = name;
            this.expectedStartDate = startDate;
            this.expectedEndDate = endDate;
            this.projectId = projectId;
            this.tasks = tasks;
        }

        public project(string name, DateTime startDate, DateTime endDate, Guid projectId, customer customer)
        {
            this.name = name;
            this.expectedStartDate = startDate;
            this.expectedEndDate = endDate;
            this.projectId = projectId;
            this.theCustomer = customer;
        }        

    }
}
