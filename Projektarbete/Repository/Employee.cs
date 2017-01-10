using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbete.Repository
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool OnParentalLeave { get; set; }
        public int DepartmentId { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
