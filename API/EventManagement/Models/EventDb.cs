using EventLib;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagement.Models
{
    public class EventDb:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<MeetingParticipant> MeetingParticipants { get; set; }
        public DbSet<EventParticipant> EventParticipants { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = M5290501; Database = Event; integrated security = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Events>().ToTable("Event");
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Meeting>().ToTable("Meeting");
            modelBuilder.Entity<MeetingParticipant>().ToTable("MeetingParticipant");
            modelBuilder.Entity<EventParticipant>().ToTable("EventParticipant");
            modelBuilder.Entity<Credential>().ToTable("Credential");
            modelBuilder.Entity<Role>().ToTable("Role");


            modelBuilder.Entity<Department>().HasIndex(a => a.DeptId).IsUnique();
            modelBuilder.Entity<Department>().Property(a => a.DeptId);

            modelBuilder.Entity<Employee>().HasIndex(a => a.Eid).IsUnique();
            modelBuilder.Entity<Employee>().Property(a => a.Eid).ValueGeneratedOnAdd();

            modelBuilder.Entity<Events>().HasIndex(b => b.EventId).IsUnique();
            modelBuilder.Entity<Events>().Property(b => b.EventId).ValueGeneratedOnAdd();

            modelBuilder.Entity<Meeting>().HasIndex(c => c.MId).IsUnique();
            modelBuilder.Entity<Meeting>().Property(c => c.MId).ValueGeneratedOnAdd();

            modelBuilder.Entity<Role>().HasIndex(d => d.Rid).IsUnique();
            modelBuilder.Entity<Role>().Property(d => d.Rid).ValueGeneratedOnAdd();

            modelBuilder.Entity<Registration>().HasIndex(d => d.Regid).IsUnique();
            modelBuilder.Entity<Registration>().Property(d => d.Regid).ValueGeneratedOnAdd();

            modelBuilder.Entity<EventParticipant>()
                .HasKey(c => new { c.EventId, c.DeptId });

            modelBuilder.Entity<MeetingParticipant>()
                .HasKey(d => new { d.MId, d.EmpId });

        }
    }
}
