using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendance.Domain.Entities
{
    public class Employee
    {
        [Key]
        public Guid EmployeeId { get; set; }
        public Guid LookUpId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Department { get; set; }
        public string? Designation { get; set; }
        public DateTime JoiningDate { get; set; }
        public decimal Salary { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
