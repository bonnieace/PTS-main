using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSProjectLibrary
{
    public class PTSCustomerFacade : PTSSuperFacade
    {
        private new DAOs.AdminDAO dao;

        public PTSCustomerFacade() :base(new DAOs.CustomerDAO())
        {
            dao =  (DAOs.AdminDAO)base.dao;
        }
        public project[] GetListOfProjects()//int customerId
        {
            return (dao.GetListOfProjects().ToArray());//customerId
        }
        public int Authenticate(string username, string password)
        {
            if (username == "" || password == "")
            {
                throw new Exception("Missing Data");
            }
            return dao.Authenticate(username, password);
        }

    }
}
