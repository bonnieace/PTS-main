namespace PTSProjectAdmin
{
    partial class formAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.welcomePage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.projectsPage = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.newPage = new System.Windows.Forms.TabPage();
            this.taskPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.expectedEnd = new System.Windows.Forms.TextBox();
            this.expectedStart = new System.Windows.Forms.TextBox();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.Customer = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.projectComboBox = new System.Windows.Forms.ComboBox();
            this.teamComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox2 = new System.Windows.Forms.TextBox();
            this.expectedEnd2 = new System.Windows.Forms.TextBox();
            this.expectedStart2 = new System.Windows.Forms.TextBox();
            this.taskListBox = new System.Windows.Forms.ListBox();
            this.addButton2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.welcomePage.SuspendLayout();
            this.projectsPage.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.newPage.SuspendLayout();
            this.taskPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(110, 26);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(401, 26);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(586, 24);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.welcomePage);
            this.tabControl1.Controls.Add(this.projectsPage);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(1, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(715, 417);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // welcomePage
            // 
            this.welcomePage.Controls.Add(this.label4);
            this.welcomePage.Controls.Add(this.label3);
            this.welcomePage.Location = new System.Drawing.Point(4, 22);
            this.welcomePage.Name = "welcomePage";
            this.welcomePage.Padding = new System.Windows.Forms.Padding(3);
            this.welcomePage.Size = new System.Drawing.Size(707, 391);
            this.welcomePage.TabIndex = 0;
            this.welcomePage.Text = "Welcome";
            this.welcomePage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(46, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(632, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Inorder to start using the tools, you must login using the fields above.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(395, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome To Administrator tools";
            // 
            // projectsPage
            // 
            this.projectsPage.Controls.Add(this.tabControl2);
            this.projectsPage.Location = new System.Drawing.Point(4, 22);
            this.projectsPage.Name = "projectsPage";
            this.projectsPage.Padding = new System.Windows.Forms.Padding(3);
            this.projectsPage.Size = new System.Drawing.Size(707, 391);
            this.projectsPage.TabIndex = 1;
            this.projectsPage.Text = "Projects";
            this.projectsPage.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.newPage);
            this.tabControl2.Controls.Add(this.taskPage);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(703, 387);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl2_Selected);
            // 
            // newPage
            // 
            this.newPage.Controls.Add(this.groupBox1);
            this.newPage.Location = new System.Drawing.Point(4, 22);
            this.newPage.Name = "newPage";
            this.newPage.Padding = new System.Windows.Forms.Padding(3);
            this.newPage.Size = new System.Drawing.Size(695, 361);
            this.newPage.TabIndex = 0;
            this.newPage.Text = "New";
            this.newPage.UseVisualStyleBackColor = true;
            // 
            // taskPage
            // 
            this.taskPage.Controls.Add(this.groupBox2);
            this.taskPage.Location = new System.Drawing.Point(4, 22);
            this.taskPage.Name = "taskPage";
            this.taskPage.Padding = new System.Windows.Forms.Padding(3);
            this.taskPage.Size = new System.Drawing.Size(695, 361);
            this.taskPage.TabIndex = 1;
            this.taskPage.Text = "Task";
            this.taskPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.customerComboBox);
            this.groupBox1.Controls.Add(this.expectedStart);
            this.groupBox1.Controls.Add(this.expectedEnd);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(24, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Project";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Expected End:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Expected Start:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Customer:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(154, 44);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(102, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // expectedEnd
            // 
            this.expectedEnd.Location = new System.Drawing.Point(154, 144);
            this.expectedEnd.Name = "expectedEnd";
            this.expectedEnd.Size = new System.Drawing.Size(102, 20);
            this.expectedEnd.TabIndex = 5;
            // 
            // expectedStart
            // 
            this.expectedStart.Location = new System.Drawing.Point(154, 95);
            this.expectedStart.Name = "expectedStart";
            this.expectedStart.Size = new System.Drawing.Size(102, 20);
            this.expectedStart.TabIndex = 6;
            this.expectedStart.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(154, 195);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(122, 21);
            this.customerComboBox.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(154, 240);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(65, 29);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.projectComboBox);
            this.groupBox2.Controls.Add(this.labelEndDate);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.labelStartDate);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.Customer);
            this.groupBox2.Controls.Add(this.labelCustomer);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 334);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Existing Projects";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addButton2);
            this.groupBox3.Controls.Add(this.expectedStart2);
            this.groupBox3.Controls.Add(this.expectedEnd2);
            this.groupBox3.Controls.Add(this.nameTextBox2);
            this.groupBox3.Controls.Add(this.teamComboBox);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Location = new System.Drawing.Point(8, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 239);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Task";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.taskListBox);
            this.groupBox4.Location = new System.Drawing.Point(335, 95);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 239);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tasks";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Select Project";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.Location = new System.Drawing.Point(373, 59);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(85, 13);
            this.labelCustomer.TabIndex = 3;
            this.labelCustomer.Text = "labelCustomer";
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.Location = new System.Drawing.Point(278, 59);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(51, 13);
            this.Customer.TabIndex = 4;
            this.Customer.Text = "Customer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(257, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Expected Start:";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartDate.Location = new System.Drawing.Point(373, 31);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(83, 13);
            this.labelStartDate.TabIndex = 6;
            this.labelStartDate.Text = "labelStartDate";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(477, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Expected End:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndDate.Location = new System.Drawing.Point(560, 31);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(76, 13);
            this.labelEndDate.TabIndex = 8;
            this.labelEndDate.Text = "labelEndDate";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(60, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Expected Start:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Expected End:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(50, 144);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "Team:";
            // 
            // projectComboBox
            // 
            this.projectComboBox.FormattingEnabled = true;
            this.projectComboBox.Location = new System.Drawing.Point(84, 28);
            this.projectComboBox.Name = "projectComboBox";
            this.projectComboBox.Size = new System.Drawing.Size(122, 21);
            this.projectComboBox.TabIndex = 9;
            this.projectComboBox.SelectedIndexChanged += new System.EventHandler(this.projectComboBox_SelectedIndexChanged);
            // 
            // teamComboBox
            // 
            this.teamComboBox.FormattingEnabled = true;
            this.teamComboBox.Location = new System.Drawing.Point(146, 141);
            this.teamComboBox.Name = "teamComboBox";
            this.teamComboBox.Size = new System.Drawing.Size(129, 21);
            this.teamComboBox.TabIndex = 10;
            // 
            // nameTextBox2
            // 
            this.nameTextBox2.Location = new System.Drawing.Point(146, 27);
            this.nameTextBox2.Name = "nameTextBox2";
            this.nameTextBox2.Size = new System.Drawing.Size(101, 20);
            this.nameTextBox2.TabIndex = 13;
            // 
            // expectedEnd2
            // 
            this.expectedEnd2.Location = new System.Drawing.Point(146, 105);
            this.expectedEnd2.Name = "expectedEnd2";
            this.expectedEnd2.Size = new System.Drawing.Size(101, 20);
            this.expectedEnd2.TabIndex = 14;
            // 
            // expectedStart2
            // 
            this.expectedStart2.Location = new System.Drawing.Point(146, 64);
            this.expectedStart2.Name = "expectedStart2";
            this.expectedStart2.Size = new System.Drawing.Size(101, 20);
            this.expectedStart2.TabIndex = 15;
            // 
            // taskListBox
            // 
            this.taskListBox.FormattingEnabled = true;
            this.taskListBox.Location = new System.Drawing.Point(17, 26);
            this.taskListBox.Name = "taskListBox";
            this.taskListBox.Size = new System.Drawing.Size(284, 186);
            this.taskListBox.TabIndex = 0;
            // 
            // addButton2
            // 
            this.addButton2.Location = new System.Drawing.Point(146, 182);
            this.addButton2.Name = "addButton2";
            this.addButton2.Size = new System.Drawing.Size(52, 20);
            this.addButton2.TabIndex = 16;
            this.addButton2.Text = "ADD";
            this.addButton2.UseVisualStyleBackColor = true;
            this.addButton2.Click += new System.EventHandler(this.addButton2_Click);
            // 
            // formAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 491);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formAdmin";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.welcomePage.ResumeLayout(false);
            this.welcomePage.PerformLayout();
            this.projectsPage.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.newPage.ResumeLayout(false);
            this.taskPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage welcomePage;
        private System.Windows.Forms.TabPage projectsPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage newPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.TextBox expectedStart;
        private System.Windows.Forms.TextBox expectedEnd;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage taskPage;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox projectComboBox;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Customer;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox taskListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addButton2;
        private System.Windows.Forms.TextBox expectedStart2;
        private System.Windows.Forms.TextBox expectedEnd2;
        private System.Windows.Forms.TextBox nameTextBox2;
        private System.Windows.Forms.ComboBox teamComboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}

