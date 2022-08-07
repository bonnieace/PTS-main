using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PTSProjectLibrary.DAOs
{
    public class SuperDAO
    {

        protected customer GetCustomer(int custId)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            customer cust;

            sql = "SELECT * FROM customer WHERE CustomerID = " + custId;
            cn = new SqlConnection(Properties.Settings.Default.PTSProject2ConnectionString);
            cmd = new SqlCommand(sql, cn);

            try
            {
                cn.Open();
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                dr.Read();
                cust = new customer(dr["CustomerName"].ToString(), (int)dr["CustomerID"]);
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Getting Customer", ex);
            }
            finally
            {
                cn.Close();
            }
            return cust;
        }
        public List<task> GetListOfTasks(Guid projectId)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            List<task> tasks;
            tasks = new List<task>();
            sql = "SELECT * FROM task WHERE ProjectID = '" + projectId + "'";
            cn = new SqlConnection(Properties.Settings.Default.PTSProject2ConnectionString);
            cmd = new SqlCommand(sql, cn);

            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    task t = new task((Guid)dr["TaskID"], dr["TaskName"].ToString(), (Status)((int)dr["StatusID"]));
                    tasks.Add(t);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error getting task list", ex);
            }
            finally
            {
                cn.Close();
            }
            return tasks;
        }
    }
}
