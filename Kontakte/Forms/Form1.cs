﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace KontakteApp
{
    public partial class Form1 : Form
    {
        private List<Employee> employees = new List<Employee>();
        private List<Task> tasks = new List<Task>();

        public Form1()
        {
            InitializeComponent();
        }

        // Initializes the data source and populates the DataGridView control.
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateLists();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = tasks;
            AddColumns();
        }

        // Populates the employees and tasks lists. 
        private void PopulateLists()
        {
            employees.Add(new Employee("Harry"));
            employees.Add(new Employee("Sally"));
            employees.Add(new Employee("Roy"));
            employees.Add(new Employee("Pris"));
            tasks.Add(new Task(1, employees[1]));
            tasks.Add(new Task(2));
            tasks.Add(new Task(3, employees[2]));
            tasks.Add(new Task(4));
        }

        // Configures columns for the DataGridView control.
        private void AddColumns()
        {
            DataGridViewTextBoxColumn idColumn =
                new DataGridViewTextBoxColumn();
            idColumn.Name = "Task";
            idColumn.DataPropertyName = "Id";
            idColumn.ReadOnly = true;

            DataGridViewComboBoxColumn assignedToColumn =
                new DataGridViewComboBoxColumn();

            // Populate the combo box drop-down list with Employee objects. 
            foreach (Employee e in employees) assignedToColumn.Items.Add(e);

            // Add "unassigned" to the drop-down list and display it for 
            // empty AssignedTo values or when the user presses CTRL+0. 
            assignedToColumn.Items.Add("unassigned");
            assignedToColumn.DefaultCellStyle.NullValue = "unassigned";

            assignedToColumn.Name = "Assigned To";
            assignedToColumn.DataPropertyName = "AssignedTo";
            assignedToColumn.AutoComplete = true;
            assignedToColumn.DisplayMember = "Name";
            assignedToColumn.ValueMember = "Self";

            // Add a button column. 
            DataGridViewButtonColumn buttonColumn =
                new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "";
            buttonColumn.Name = "Status Request";
            buttonColumn.Text = "Request Status";
            buttonColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(idColumn);
            dataGridView1.Columns.Add(assignedToColumn);
            dataGridView1.Columns.Add(buttonColumn);

            // Add a CellClick handler to handle clicks in the button column.
            dataGridView1.CellClick +=
                new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }

        // Reports on task assignments. 
        private void reportButton_Click(object sender, EventArgs e)
        {
            StringBuilder report = new StringBuilder();
            foreach (Task t in tasks)
            {
                String assignment =
                    t.AssignedTo == null ?
                    "unassigned" : "assigned to " + t.AssignedTo.Name;
                report.AppendFormat("Task {0} is {1}.", t.Id, assignment);
                report.Append(Environment.NewLine);
            }
            MessageBox.Show(report.ToString(), "Task Assignments");
        }

        // Calls the Employee.RequestStatus method.
        void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells. 
            if (e.RowIndex < 0 || e.ColumnIndex !=
                dataGridView1.Columns["Status Request"].Index) return;

            // Retrieve the task ID.
            Int32 taskID = (Int32)dataGridView1[0, e.RowIndex].Value;

            // Retrieve the Employee object from the "Assigned To" cell.
            Employee assignedTo = dataGridView1.Rows[e.RowIndex]
                .Cells["Assigned To"].Value as Employee;

            // Request status through the Employee object if present. 
            if (assignedTo != null)
            {
                assignedTo.RequestStatus(taskID);
            }
            else
            {
                MessageBox.Show(String.Format(
                    "Task {0} is unassigned.", taskID), "Status Request");
            }
        }

    }
}
