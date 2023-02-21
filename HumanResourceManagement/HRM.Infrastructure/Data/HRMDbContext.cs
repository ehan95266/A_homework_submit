using System;
using HRM.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace HRM.Infrastructure.Data
{
	public class HRMDbContext:DbContext
	{
		public HRMDbContext(DbContextOptions<HRMDbContext> options):base(options)
		{
			//connectionstring in appsetting.json in HRM.WebMVCApp

		}

        // dbccontext will create the properties
        //DbSet is like a table
		public DbSet<JobRequirement> JobRequirement { get; set; }
        public DbSet<JobCategory> JobCategory{ get; set; }
        public DbSet<Candidate> Candidate { get; set; }
        public DbSet<Submission> Submission { get; set; }
        public DbSet<Interview> Interview { get; set; }
        public DbSet<InterviewType> InterviewType { get; set; }
        public DbSet<InterviewStatus> InterviewStatus { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeRole> EmployeeRole { get; set; }
        public DbSet<EmployeeType> EmployeeType { get; set; }
        public DbSet<EmployeeStatus> EmployeeStatus { get; set; }


    }
}

