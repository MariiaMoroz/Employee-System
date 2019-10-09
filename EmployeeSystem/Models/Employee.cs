using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeSystem.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime HireDate { get; set; }
        public string Specialty { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}