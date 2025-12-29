using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendance.Domain.Entities
{
    public class Attendance
    {
        [Key]
        public Guid AttendanceId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid LookUpId { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly? CheckInTime { get; set; }
        public TimeOnly? CheckOutTime { get; set; }
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
