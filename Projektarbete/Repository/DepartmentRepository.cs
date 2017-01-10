using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete.Repository
{
    public class DepartmentRepository
    {
        public static List<Department> LoadDepartments()
        {
            string connectionString = Properties.Settings.Default.ProjektarbeteConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.CommandText = "SELECT * FROM Department " +
                                          "ORDER BY Name";
                    command.Connection = connection;

                    using (var reader = command.ExecuteReader())
                    {
                        var departments = new List<Department>();
                        while (reader.Read())
                        {
                            var department = new Department
                            {
                                Id = (int)reader["Id"],
                                Name = (string)reader["Name"],
                            };
                            departments.Add(department);
                        }
                        return departments;
                    }
                }
            }
        }
    }
}
