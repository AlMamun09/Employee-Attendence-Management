using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendance.Application.DTOs
{
    public class LookUpDto
    {
        public Guid LookUpId { get; set; }
        public string? Category { get; set; }
        public string? Value { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }

    public class CreateLookUpDto
    {
        public string? Category { get; set; }
        public string? Value { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
    }

    public class UpdateLookUpDto
    {
        public Guid LookUpId { get; set; }
        public string? Category { get; set; }
        public string? Value { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}
