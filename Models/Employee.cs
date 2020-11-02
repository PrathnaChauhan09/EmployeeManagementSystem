using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required]
        [StringLength(20)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        public string Qualification { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]{10}$")]
        public string ContactNo { get; set; }
        [Required]
        public int DepartmentID { get; set; }

        public Department Department { get; set; }
    }
}
