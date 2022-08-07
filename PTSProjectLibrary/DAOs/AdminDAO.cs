using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PTSProjectLibrary.DAOs
{
    internal class AdminDAO : SuperDAO
    {
        public int Authenticate(string username, string password)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            sql = String.Format("SELECT UserID FROM person WHERE Username='{0}' AND Persons_Password='{1}'", username, password); // Is_Administrator=1 AND 

            cn = new SqlConnection(Properties.Settings.Default.PTSProject2ConnectionString);
            cmd = new SqlCommand(sql, cn);
            int id = 0;
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (dr.Read())
                {
                    id = (int)dr["UserID"];
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
        public void CreateProject(string name, DateTime startDate, DateTime endDate, int customerId, int administratorId)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            Guid projectId = Guid.NewGuid();
            sql = "INSERT INTO project (ProjectID, ProjectName, ExpectedStartDate, ExpectedEndDate, CustomerID, AdministartorID)";
            sql += String.Format("VALUES ('{0}', '{1}', '{2}', '{3}', {4},{5})", projectId, name, startDate, endDate, customerId, administratorId);
            cn = new SqlConnection(Properties.Settings.Default.PTSProject2ConnectionString);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Inserting", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<customer> GetListOfCustomers()
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            List<customer> customers;
            customers = new List<customer>();
            sql = "SELECT * FROM customer";
            cn = new SqlConnection(Properties.Settings.Default.PTSProject2ConnectionString);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    customer c = new customer(dr["CustomerName"].ToString(), (int)dr["CustomerID"]);
                    customers.Add(c);
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
            return customers;
        }
        public List<project> GetListOfProjects()// int adminId
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            List<project> projects;
            projects = new List<project>();
            sql = "SELECT * FROM project"; //WHERE AdministratorID = adminId
            cn = new SqlConnection(Properties.Settings.Default.PTSProject2ConnectionString);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    customer cust = GetCustomer((int)dr["CustomerID"]);
                    project p = new project(dr["ProjectName"].ToString(), (DateTime)dr["ExpectedStartDate"], (DateTime)dr["ExpectedEndDate"], (Guid)dr["ProjectID"], cust);
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
        public List<team> GetListOfTeams()
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            List<team> teams;
            teams = new List<team>();
            sql = "SELECT * FROM team";
            cn = new SqlConnection(Properties.Settings.Default.PTSProject2ConnectionString);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    team t = new team((int)dr["TeamID"], dr["Team_Location"].ToString(), dr["TeamName"].ToString(), null);
                    teams.Add(t);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error getting team list", ex);
            }
            finally
            {
                cn.Close();
            }
            return teams;
        }
        public void CreateTask(string name, DateTime startDate, DateTime endDate, int teamId, Guid projectId)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            Guid taskId = Guid.NewGuid();
            sql = "INSERT INTO task (TaskID, TaskName, ExpectedStartDate, ExpectedEndDate, ProjectID, TeamID, StatusID)";
            sql += String.Format("VALUES ( '{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6})", taskId, name, startDate, endDate, projectId, teamId, 1);
            cn = new SqlConnection(Properties.Settings.Default.PTSProject2ConnectionString);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error Inserting", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
