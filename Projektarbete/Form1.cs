using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projektarbete.Repository;

namespace Projektarbete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            employeesList.DataSource = EmployeeRepository.LoadEmployees().ToList();
            departmentBox.DataSource = DepartmentRepository.LoadDepartments();
            departmentsList.DataSource = DepartmentRepository.LoadDepartments().ToList();
        }

        private void employeesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (Employee)employeesList.SelectedItem;

            nameBox.Text = selectedItem.Name;
            emailBox.Text = selectedItem.Email;
            dateBox.Value = selectedItem.DateOfBirth;
            salaryBox.Value = selectedItem.Salary;
            if (departmentBox.SelectedIndex >=0)
            departmentBox.SelectedIndex = selectedItem.DepartmentId;
            onPaLeCheckbox.Checked = selectedItem.OnParentalLeave;
        }

        private void departmentsList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selectedItem = (Department)departmentsList.SelectedItem;

            employeesDepartmentList.DataSource =
                EmployeeRepository.LoadEmployees().Where(x => x.DepartmentId == selectedItem.Id).ToList();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var selectedEmployee = (Employee)employeesList.SelectedItem;
            selectedEmployee.Name = nameBox.Text;
            selectedEmployee.Email = emailBox.Text;
            selectedEmployee.DateOfBirth = dateBox.Value;
            selectedEmployee.Salary = (int) salaryBox.Value;
            selectedEmployee.DepartmentId = departmentBox.SelectedIndex;
            selectedEmployee.OnParentalLeave = onPaLeCheckbox.Checked;

            if (EmployeeRepository.SaveEmployee(selectedEmployee) && salaryBox.Text != "")
            {
                MessageBox.Show("Employee Saved!");
                employeesList.DataSource = EmployeeRepository.LoadEmployees().ToList();
            }
            else
                MessageBox.Show("Failed to save Employee");

        }

        private void createEmployeeButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.FormClosed += form2_FormClosed;
            form2.Show();
        }

        void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            employeesList.DataSource = EmployeeRepository.LoadEmployees().ToList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            var deletePromt = MessageBox.Show("Are you sure you want to delete Employee?",
                                              "Employee Deleted!",
                                               MessageBoxButtons.YesNo);
            if (deletePromt == DialogResult.Yes)
            {
                var selectedEmployee = (Employee)employeesList.SelectedItem;
                EmployeeRepository.DeleteEmployee(selectedEmployee);
                MessageBox.Show("Employee Deleted!");
                employeesList.DataSource = EmployeeRepository.LoadEmployees().ToList();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            employeesList.DataSource = EmployeeRepository.LoadEmployees().ToList();
            departmentBox.DataSource = DepartmentRepository.LoadDepartments();
            departmentsList.DataSource = DepartmentRepository.LoadDepartments().ToList();
        }
    }
}
