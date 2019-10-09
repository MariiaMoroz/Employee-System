using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeSystem.ViewModels
{
    public class HireDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? HireDate { get; set; }

        public int EmployeeCount { get; set; }
    }
   
}

