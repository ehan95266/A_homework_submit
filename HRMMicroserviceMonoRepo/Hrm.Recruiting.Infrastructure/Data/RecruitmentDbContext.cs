using System;
using Hrm.Recruiting.ApplicationCoreLayer.Entity;
using Microsoft.EntityFrameworkCore;

namespace Hrm.Recruiting.Infrastructure.Data
{
    public class RecruitmentDbContext : DbContext
    {
        public RecruitmentDbContext(DbContextOptions<RecruitmentDbContext> option) : base(option)
        {

        }

        public DbSet<JobCategory> JobCategory { get; set; }
        public DbSet<JobRequirement> JobRequirement { get; set; }
        public DbSet<Candidate> Candidate { get; set; }
        public DbSet<Submission> Submission { get; set; }
        public DbSet<SubmissionStatus> SubmissionStatus { get; set; }

    }

}

