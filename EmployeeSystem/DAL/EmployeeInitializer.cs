using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EmployeeSystem.Models;

namespace EmployeeSystem.DAL
{
    public class EmployeeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            var Employees = new List<Employee>
            {
            new Employee{FirstName="David",LastName="Marlow",HireDate=DateTime.Parse("2005-09-01")},
            new Employee{FirstName="Christian",LastName="Slate",HireDate=DateTime.Parse("2002-09-01")},
            new Employee{FirstName="David",LastName="Page",HireDate=DateTime.Parse("2003-09-01")},
            new Employee{FirstName="Carlos",LastName="Montoya",HireDate=DateTime.Parse("2002-09-01")},
            new Employee{FirstName="Trevor",LastName="Barton",HireDate=DateTime.Parse("2002-09-01")},
            new Employee{FirstName="Robert",LastName="Munger",HireDate=DateTime.Parse("2001-09-01")},
            new Employee{FirstName="Carlos",LastName="Monaco",HireDate=DateTime.Parse("2003-09-01")},
            new Employee{FirstName="Nino",LastName="Brown",HireDate=DateTime.Parse("2005-09-01")}
            };

            Employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
            var Divisions = new List<Division>
            {
            new Division{DivisionID=1050,Title="Engineering",Salary=38000,},
            new Division{DivisionID=4022,Title="Operations",Salary=45900,},
            new Division{DivisionID=4041,Title="Sales",Salary=65246,},
            new Division{DivisionID=1045,Title="Service",Salary=84245,},
            new Division{DivisionID=3141,Title="Accounting",Salary=56435,},
            new Division{DivisionID=2021,Title="Support",Salary=68987,},
            new Division{DivisionID=2042,Title="HR",Salary=76453,}
            };
            Divisions.ForEach(s => context.Divisions.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{EmployeeID=1,DivisionID=1050,Level=Level.I},
            new Enrollment{EmployeeID=1,DivisionID=4022,Level=Level.III},
            new Enrollment{EmployeeID=1,DivisionID=4041,Level=Level.II},
            new Enrollment{EmployeeID=2,DivisionID=1045,Level=Level.II},
            new Enrollment{EmployeeID=2,DivisionID=3141,Level=Level.IIII},
            new Enrollment{EmployeeID=2,DivisionID=2021,Level=Level.V},
            new Enrollment{EmployeeID=3,DivisionID=1050},
            new Enrollment{EmployeeID=4,DivisionID=1050,},
            new Enrollment{EmployeeID=4,DivisionID=4022,Level=Level.III},
            new Enrollment{EmployeeID=5,DivisionID=4041,Level=Level.III},
            new Enrollment{EmployeeID=6,DivisionID=1045},
            new Enrollment{EmployeeID=7,DivisionID=3141,Level=Level.I},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}