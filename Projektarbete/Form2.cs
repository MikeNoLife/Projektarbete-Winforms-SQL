using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projektarbete.Repository;

namespace Projektarbete
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            departmentBox.DataSource = DepartmentRepository.LoadDepartments();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var createEmployee = new Employee();
            createEmployee.Name = nameBox.Text;
            createEmployee.Email = emailBox.Text;
            createEmployee.DateOfBirth = dateBox.Value;
            createEmployee.Salary = (int)salaryBox.Value;
            createEmployee.DepartmentId = departmentBox.SelectedIndex;
            createEmployee.OnParentalLeave = onPaLeCheckbox.Checked;

            if (EmployeeRepository.CreateEmployee(createEmployee) && salaryBox.Text != "")
            {
                MessageBox.Show("Employee Saved!");
                this.Close();
            }
            else
                MessageBox.Show("Failed to save Employee");

        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
