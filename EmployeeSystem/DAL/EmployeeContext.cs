using EmployeeSystem.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EmployeeSystem.DAL
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("EmployeeContext")
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Division> Divisions { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}