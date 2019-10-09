using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeSystem.Models
{
    public class Division
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DivisionID { get; set; }
        public string Title { get; set; }
        public int Salary { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}