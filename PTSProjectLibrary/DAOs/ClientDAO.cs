using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PTSProjectLibrary.DAOs
{
    internal class ClientDAO : SuperDAO
    {
        public teamleader Authenticate(string username, string password)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            teamleader leader = null;
            sql = String.Format("SELECT DISTINCT person.Persons_Name, UserID, TeamID FROM person INNER JOIN team ON(team.TeamLeaderID = person.UserID) WHERE Username = '{0}' AND Persons_Password = '{1}'", username, password);

            cn = new SqlConnection(Properties.Settings.Default.PTSProject2ConnectionString);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (dr.Read())
                {
                    leader = new teamleader(dr["Name"].ToString(), (int)dr["TeamId"], (int)dr["TeamId"]);
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
            return leader;
        }
        public List<project> GetListOfProjects(int teamId)
        {
            string sql;
            SqlConnection cn;
            SqlCommand cmd;
            SqlDataReader dr;
            List<project> projects;
            projects = new List<project>();
            sql = "SELECT P.* FROM project AS P INNER JOIN task AS T ON (P.ProjectID = T.ProjectID) WHERE T.TeamID = " + teamId;
            cn = new SqlConnection(Properties.Settings.Default.PTSProject2ConnectionString);
            cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    customer cust = GetCustomer((int)dr["CustomerId"]);
                    project p = new project(dr["Name"].ToString(), (DateTime)dr["ExpectedStartDate"], (DateTime)dr["ExpectedEndDate"], (Guid)dr["ProjectId"], cust);
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
