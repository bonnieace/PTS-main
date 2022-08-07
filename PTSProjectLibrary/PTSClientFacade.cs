using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSProjectLibrary
{
    public class PTSClientFacade : PTSSuperFacade
    {
        private new DAOs.ClientDAO dao;

        public PTSClientFacade() : base(new DAOs.ClientDAO())
        {
            dao = (DAOs.ClientDAO)base.dao;
        }
        public teamleader Authenticate(string username, string password)
        {
            if(username == null || password == null)
            {
                throw new Exception("Missing Data");
            }
            return dao.Authenticate(username, password);
        }
        public project[] GetListOfProjects(int teamId)
        {
            return (dao.GetListOfProjects(teamId).ToArray());
        }
    }
}
