using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeSystem.Models
{
    public enum Level
    {
        I, II, III, IIII, V
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int DivisionID { get; set; }
        public int EmployeeID { get; set; }
        public Level? Level { get; set; }

        public virtual Division Division { get; set; }
        public virtual Employee Employee { get; set; }
    }
}