using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendance.Application.DTOs
{
    public class EmployeeDto
    {
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
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }

    public class CreateEmployeeDto
    {
        public Guid LookUpId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Department { get; set; }
        public string? Designation { get; set; }
        public DateTime JoiningDate { get; set; }
        public decimal Salary { get; set; }
        public string? ImageUrl { get; set; }
    }

    public class UpdateEmployeeDto
    {
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
    }
}
