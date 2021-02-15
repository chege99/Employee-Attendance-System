using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Include This Library first, Helps in database migration
using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public enum Department
    {
        Software, Finance, Admin, Marketting, Research, HR
    }
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required] 
        public string Position { get; set; }
        [Required] 
        public Department Department { get; set; }

        public double Salary { get; set; }
        public DateTime DateJoined { get; set; }
        public DateTime LastUpdated { get; set; }

    }
}
