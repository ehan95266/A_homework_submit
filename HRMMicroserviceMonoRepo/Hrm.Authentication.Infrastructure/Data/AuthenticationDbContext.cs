using System;
using Hrm.Authentication.ApplicationCoreLayer.Entity;
using Microsoft.EntityFrameworkCore;

namespace Hrm.Authentication.Infrastructure.Data
{
	public class AuthenticationDbContext:DbContext
	{
		public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options):base(options)
		{
		}

		public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Account> Account { get; set; }
    }
}

