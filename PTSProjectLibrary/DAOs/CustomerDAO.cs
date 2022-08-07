using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PTSProjectLibrary.DAOs
{
    internal class CustomerDAO : SuperDAO
    {
        public int Authenticate(string username, string password)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            sql = String.Format("SELECT CustomerID FROM customer WHERE Username='{0}' AND Customer_Password = '{1}'", username, password);

            cn = new SqlConnection(Properties.Settings.Default.PTSProject2ConnectionString);
            cmd = new SqlCommand(sql, cn);
            int id = 0;
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (dr.Read())
                {
                    id = (int)dr["CustomerID"];
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Accessing Database", ex);
            }
            finally
            {
                cn.Close();
            }
            return id;
        }
        public List<project> GetListOfProjects(int customerId)
        {
            string sql;
            SqlConnection cn, cn2;
            SqlCommand cmd, cmd2;
            SqlDataReader dr, dr2;
            List<project> projects;
            projects = new List<project>();
            sql = "SELECT * FROM project WHERE CustomerID = " + customerId;
            cn = new SqlConnection(Properties.Settings.Default.PTSProject2ConnectionString);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    List<task> tasks = new List<task>();
                    sql = "SELECT * FROM task WHERE ProjectID = '" + dr["ProjectID"].ToString() + "'";
                    cn2 = new SqlConnection(Properties.Settings.Default.PTSProject2ConnectionString);
                    cmd2 = new SqlCommand(sql, cn2);
                    cn2.Open();
                    dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        task t = new task((Guid)dr2["TaskID"], dr2["TaskName"].ToString(), (Status)dr2["StatusID"]);
                        tasks.Add(t);
                    }
                    dr2.Close();
                    project p = new project(dr["ProjectName"].ToString(), (DateTime)dr["ExpectedStartDate"], (DateTime)dr["ExpectedEndDate"], (Guid)dr["ProjectID"], tasks); // there was tasks at the end
                    projects.Add(p);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Getting list", ex);
            }
            finally
            {
                cn.Close();
            }
            return projects;
        }
    }
}
