using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_8
{
    public partial class DirectoryForm : Form
    {
        public DirectoryForm()
        {
            InitializeComponent();
        }

        private void employeeListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeListBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDirectoryDataSet);

        }

        private void DirectoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDirectoryDataSet.EmployeeList' table. You can move, or remove it, as needed.
            this.employeeListTableAdapter.Fill(this.employeeDirectoryDataSet.EmployeeList);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.employeeListTableAdapter.EmployeeSearch(this.employeeDirectoryDataSet.EmployeeList,
                searchTextBox.Text);
        }

        private void showEmployeesButton_Click(object sender, EventArgs e)
        {
            this.employeeListTableAdapter.Fill(this.employeeDirectoryDataSet.EmployeeList);
        }

        private void maxSalaryButton_Click(object sender, EventArgs e)
        {
            //variable to hold the maximum salary
            decimal maxSalary;

            //get the max salary
            maxSalary = (decimal) this.employeeListTableAdapter.MaxQuery();

            MessageBox.Show("The Highest Salary is " + maxSalary.ToString("c") + " an hour.");
        }

        private void minSalaryButton_Click(object sender, EventArgs e)
        {
            //variable to hold minimum salary
            decimal minSalary;

            //get the minimum salary
            minSalary = (decimal) this.employeeListTableAdapter.MinQuery();

            //display the minimum salary
            MessageBox.Show("The minimum salary is " + minSalary.ToString("c") + " an hour.");
        }
    }
}
