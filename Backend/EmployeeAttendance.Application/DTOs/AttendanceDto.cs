using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendance.Application.DTOs
{
    public class AttendanceDto
    {
        public Guid AttendanceId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid LookUpId { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly? CheckInTime { get; set; }
        public TimeOnly? CheckOutTime { get; set; }
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties for displaying employee info
        public string? EmployeeName { get; set; }
    }

    public class CreateAttendanceDto
    {
        public Guid EmployeeId { get; set; }
        public Guid LookUpId { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly? CheckInTime { get; set; }
        public TimeOnly? CheckOutTime { get; set; }
        public string? Notes { get; set; }
    }

    public class UpdateAttendanceDto
    {
        public Guid AttendanceId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid LookUpId { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly? CheckInTime { get; set; }
        public TimeOnly? CheckOutTime { get; set; }
        public string? Notes { get; set; }
    }
}
