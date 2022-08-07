using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSProjectLibrary
{
    public class PTSSuperFacade : MarshalByRefObject
    {
        protected DAOs.SuperDAO dao;

        public PTSSuperFacade(DAOs.SuperDAO dao)
        {
            this.dao = dao;
        }

        public task[] GetListOfTasks(Guid projectId)
        {
            return (dao.GetListOfTasks(projectId).ToArray());
        }
    }
}
