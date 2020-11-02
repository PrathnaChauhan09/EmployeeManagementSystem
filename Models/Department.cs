using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EmployeeManagementSystem.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        [Required]
        [DisplayName("Department Name")]
        public string Name { get; set; }

        public ICollection<Employee> Employees{get;set;}
    }
}
