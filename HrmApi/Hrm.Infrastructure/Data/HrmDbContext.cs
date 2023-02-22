using System;
using Hrm.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace Hrm.Infrastructure.Data
{
	public class HrmDbContext : DbContext
    {
		public HrmDbContext(DbContextOptions<HrmDbContext> options):base(options)
		{
		}

        public DbSet<JobRequirement> JobRequirement { get; set; }
        public DbSet<JobCategory> JobCategory { get; set; }
        public DbSet<Candidate> Candidate { get; set; }
    }
}

