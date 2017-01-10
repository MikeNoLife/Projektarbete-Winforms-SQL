using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektarbete.Repository
{
    public class EmployeeRepository
    {
        public static List<Employee> LoadEmployees()
        {
            string connectionString = Properties.Settings.Default.ProjektarbeteConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Employee " +
                                          "ORDER BY Name";
                    using (var reader = command.ExecuteReader())
                    {
                        var employees = new List<Employee>();
                        while (reader.Read())
                        {
                            var employee = new Employee
                            {
                                Id = (int)reader["Id"],
                                Name = (string)reader["Name"],
                                Email = (string)reader["Email"],
                                Salary = (int)reader["Salary"],
                                DateOfBirth = (DateTime)reader["DateOfBirth"],
                                OnParentalLeave = (bool)reader["OnParentalLeave"],
                                DepartmentId = (int)reader["DepartmentId"]
                            };
                            employees.Add(employee);
                        }
                        return employees;
                    }
                }
            }
        }

        public static bool SaveEmployee(Employee employee)
        {
            string connectionString = Properties.Settings.Default.ProjektarbeteConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Employee " +
                                          "SET Name = @name, Email = @email, Salary = @salary, DateOfBirth = @dateOfBirth, OnParentalLeave = @onParentalLeave, DepartmentId = @departmentId " +
                                          "From Employee WHERE Id = " + employee.Id;

                    if (Caller(employee, command))
                        return true;
                    else
                        return false;
                }
            }
        }

        public static bool CreateEmployee(Employee employee)
        {
            string connectionString = Properties.Settings.Default.ProjektarbeteConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Employee " +
                                          "VALUES (@name, @email, @salary, @dateOfBirth, @onParentalLeave, @departmentId)";

                    if (Caller(employee, command))
                    return true;
                    else
                    return false;
                }
            }
        }

        public static void DeleteEmployee(Employee employee)
        {
            string connectionString = Properties.Settings.Default.ProjektarbeteConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Employee " +
                                          "WHERE Id = @id";

                    int id = employee.Id;
                    SqlParameter idParameter = new SqlParameter("@id", SqlDbType.NVarChar);
                    idParameter.Value = id;
                    command.Parameters.Add(idParameter);

                    command.ExecuteNonQuery();
                }
            }
        }

        private static bool Caller(Employee employee, SqlCommand command)
        {
            string name = employee.Name;
            string email = employee.Email;
            int salary = employee.Salary;
            DateTime dateOfBirth = employee.DateOfBirth;
            bool onParentalLeave = employee.OnParentalLeave;
            int departmentId = employee.DepartmentId;

            SqlParameter nameParameter = new SqlParameter("@name", SqlDbType.NVarChar);
            SqlParameter emailParameter = new SqlParameter("@email", SqlDbType.NVarChar);
            SqlParameter salaryParameter = new SqlParameter("@salary", SqlDbType.Int);
            SqlParameter dateOfBirthParameter = new SqlParameter("@dateOfBirth", SqlDbType.Date);
            SqlParameter onParentalLeaveParameter = new SqlParameter("@onParentalLeave", SqlDbType.Bit);
            SqlParameter departmentIdParameter = new SqlParameter("@departmentId", SqlDbType.Int);

            Regex nameRegex = new Regex(@"^[a-öA-Ö\s]+$");
            Match nameMatch = nameRegex.Match(name);
            if (nameMatch.Success && string.IsNullOrWhiteSpace(name) == false)
            {
                nameParameter.Value = name;
                command.Parameters.Add(nameParameter);
            }
            else
            {
                MessageBox.Show("Invalid Name");
                return false;
            }

            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match emailMatch = emailRegex.Match(email);
            if (emailMatch.Success && string.IsNullOrWhiteSpace(email) == false)
            {
                emailParameter.Value = email;
                command.Parameters.Add(emailParameter);
            }
            else
            {
                MessageBox.Show("Invalid Email");
                return false;
            }

            if (dateOfBirth > DateTime.Today.AddYears(-18))
            {
                MessageBox.Show("Invalid date, employee must be over 18 years old.");
                return false;
            }

            salaryParameter.Value = salary;
            dateOfBirthParameter.Value = dateOfBirth;
            onParentalLeaveParameter.Value = onParentalLeave;
            departmentIdParameter.Value = departmentId;

            command.Parameters.Add(salaryParameter);
            command.Parameters.Add(dateOfBirthParameter);
            command.Parameters.Add(onParentalLeaveParameter);
            command.Parameters.Add(departmentIdParameter);

            command.ExecuteNonQuery();
            return true;
        }
    }
}
