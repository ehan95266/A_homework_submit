using System;
namespace Hrm.Authentication.ApplicationCoreLayer.Entity
{
	public class UserRole
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public int RoleId { get; set; }

		//navigation property
		public Account Account { get; set; }
		public Role Role { get; set; }

	}
}

