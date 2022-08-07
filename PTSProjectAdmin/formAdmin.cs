using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTSProjectLibrary;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

namespace PTSProjectAdmin
{
    public partial class formAdmin : Form
    {
        private PTSAdminFacade facade;
        private int adminId;
        private customer[] customers;
        private project[] projects;
        private team[] teams;
        private project selectedProject;
        private task[] tasks;
        public formAdmin()
        {
            InitializeComponent();
            HttpChannel channel = new HttpChannel();
            ChannelServices.RegisterChannel(channel, false);

            //facade = (PTSAdminFacade)RemotingServices.Connect(typeof(PTSAdminFacade), "http://localhost:50000/PTSAdminFacade");


            facade = new PTSAdminFacade();
            adminId = 0;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                adminId = facade.Authenticate(this.usernameTextBox.Text, this.passwordTextBox.Text);
                if (adminId != 0)
                {
                    this.usernameTextBox.Text = "";
                    this.passwordTextBox.Text = "";
                    MessageBox.Show("Successfully logged In");
                    tabControl1.SelectTab(0); //changed from 1
                    tabControl1.Enabled = true;
                }
                else
                {
                    tabControl1.SelectTab(0);
                    tabControl1.Enabled = false;
                    MessageBox.Show("Wrong Login Details");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if(tabControl1.SelectedIndex == 1)
            {
                customers = facade.GetListOfCustomers();
                customerComboBox.DataSource = customers;
                customerComboBox.DisplayMember = "Name";
                customerComboBox.ValueMember = "id";
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            DateTime endDate;

            if (nameTextBox.Text == "")
            {
                MessageBox.Show("You need to fill in the name field, hazel");
                return;
            }

            try
            {
                startDate = DateTime.Parse(expectedStart.Text);
                endDate = DateTime.Parse(expectedEnd.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("The date(s) are in the wrong format");
                return;
            }

            facade.CreateProject(nameTextBox.Text, startDate, endDate, (int)customerComboBox.SelectedValue, adminId);
            nameTextBox.Text = "";
            expectedStart.Text = "";
            expectedEnd.Text = "";
            customerComboBox.SelectedIndex = -1; //0
            MessageBox.Show("Project Successfully created");
            tabControl2.SelectTab(1);
        }

        private void tabControl2_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl2.SelectedIndex == 1)
            {
                projects = facade.GetListOfProjects();//adminId
                projectComboBox.DataSource = projects;
                projectComboBox.DisplayMember = "Name";
                projectComboBox.ValueMember = "projectId";
                setProjectDetails();

                teams = facade.GetListOfTeams();
                teamComboBox.DataSource = teams;
                teamComboBox.DisplayMember = "Name";
                teamComboBox.ValueMember = "teamId";
            }
        }
        private void setProjectDetails()
        {
            selectedProject = projects[projectComboBox.SelectedIndex];
            labelStartDate.Text = selectedProject.ExpectedStartDate.ToShortDateString();
            labelEndDate.Text = selectedProject.ExpectedEndDate.ToShortDateString();
            labelCustomer.Text = ((customer)selectedProject.TheCustomer).Name; //The Customer was in classLibrary.Find it
            UpdateTasks();
        }
        private void UpdateTasks()
        {
            tasks = facade.GetListOfTasks(selectedProject.ProjectId);
            taskListBox.DataSource = tasks;
            taskListBox.DisplayMember = "NameAndStatus";
            taskListBox.ValueMember = "taskId";
        }

        private void projectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setProjectDetails();
        }

        private void addButton2_Click(object sender, EventArgs e)
        {
            DateTime startDate;
            DateTime endDate;

            if (nameTextBox2.Text == "")
            {
                MessageBox.Show("You need to fill in the name field, hazel");
                return;
            }

            try
            {
                startDate = DateTime.Parse(expectedStart2.Text);
                endDate = DateTime.Parse(expectedEnd2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("The date(s) are in the wrong format");
                return;
            }

            facade.CreateTask(nameTextBox2.Text, startDate, endDate, (int)teamComboBox.SelectedValue, selectedProject.ProjectId);
            nameTextBox2.Text = "";
            expectedStart2.Text = "";
            expectedEnd2.Text = "";
            teamComboBox.SelectedIndex = -1;
            MessageBox.Show("Task Successfully created");
            UpdateTasks();
        }
    }
}

