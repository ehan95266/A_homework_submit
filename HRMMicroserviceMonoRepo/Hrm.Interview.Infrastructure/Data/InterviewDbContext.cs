using System;
using Hrm.Interview.ApplicationCoreLayer.Entity;
using Microsoft.EntityFrameworkCore;

namespace Hrm.Interview.Infrastructure.Data
{
	public class InterviewDbContext:DbContext
	{
        public InterviewDbContext(DbContextOptions<InterviewDbContext> options) : base(options)
        {

        }

        public DbSet<Interviews> Interviews { get; set; }
        public DbSet<InterviewType> InterviewType { get; set; }
        public DbSet<Interviewer> Interviewer { get; set; }
        public DbSet<InterviewFeedback> interviewFeedback { get; set; }
        public DbSet<Recruiter> Recruiter { get; set; }
    }
}

