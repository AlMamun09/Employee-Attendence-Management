using EmployeeAttendance.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAttendance.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<LookUp> LookUps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Employee configuration
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);
                entity.Property(e => e.Name).HasMaxLength(100);
                entity.Property(e => e.Email).HasMaxLength(150);
                entity.Property(e => e.Phone).HasMaxLength(20);
                entity.Property(e => e.Department).HasMaxLength(100);
                entity.Property(e => e.Designation).HasMaxLength(100);
                entity.Property(e => e.Salary).HasColumnType("decimal(18,2)");
                entity.Property(e => e.ImageUrl).HasMaxLength(500);
            });

            // Attendance configuration
            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.HasKey(a => a.AttendanceId);
                entity.Property(a => a.Notes).HasMaxLength(500);
                
                // Index for quick lookup by employee and date
                entity.HasIndex(a => new { a.EmployeeId, a.Date });
            });

            // LookUp configuration
            modelBuilder.Entity<LookUp>(entity =>
            {
                entity.HasKey(l => l.LookUpId);
                entity.Property(l => l.Category).HasMaxLength(100);
                entity.Property(l => l.Value).HasMaxLength(100);
                entity.Property(l => l.Description).HasMaxLength(500);
            });
        }
    }
}
