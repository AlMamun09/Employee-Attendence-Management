using Microsoft.AspNetCore.Mvc;

namespace EmployeeAttendance.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    /// <summary>
    /// Health check endpoint
    /// </summary>
    [HttpGet("health")]
    public IActionResult HealthCheck()
    {
        return Ok(new { status = "Healthy", timestamp = DateTime.UtcNow });
    }

    /// <summary>
    /// Get a greeting message
    /// </summary>
    /// <param name="name">Your name</param>
    [HttpGet("greet/{name}")]
    public IActionResult Greet(string name)
    {
        return Ok(new { message = $"Hello, {name}! Welcome to Employee & Attendance Management API." });
    }

    /// <summary>
    /// Echo back the posted data
    /// </summary>
    [HttpPost("echo")]
    public IActionResult Echo([FromBody] EchoRequest request)
    {
        return Ok(new 
        { 
            received = request.Message,
            timestamp = DateTime.UtcNow,
            length = request.Message?.Length ?? 0
        });
    }

    /// <summary>
    /// Sample employee data for testing
    /// </summary>
    [HttpGet("sample-employees")]
    public IActionResult GetSampleEmployees()
    {
        var employees = new[]
        {
            new { id = 1, name = "John Doe", email = "john@example.com", department = "IT", designation = "Developer" },
            new { id = 2, name = "Jane Smith", email = "jane@example.com", department = "HR", designation = "Manager" },
            new { id = 3, name = "Bob Johnson", email = "bob@example.com", department = "Finance", designation = "Analyst" }
        };

        return Ok(employees);
    }

    /// <summary>
    /// Sample attendance data for testing
    /// </summary>
    [HttpGet("sample-attendance")]
    public IActionResult GetSampleAttendance()
    {
        var attendance = new[]
        {
            new { employeeId = 1, employeeName = "John Doe", date = DateOnly.FromDateTime(DateTime.Today), status = "Present" },
            new { employeeId = 2, employeeName = "Jane Smith", date = DateOnly.FromDateTime(DateTime.Today), status = "Present" },
            new { employeeId = 3, employeeName = "Bob Johnson", date = DateOnly.FromDateTime(DateTime.Today), status = "Leave" }
        };

        return Ok(attendance);
    }
}

public class EchoRequest
{
    public string? Message { get; set; }
}
