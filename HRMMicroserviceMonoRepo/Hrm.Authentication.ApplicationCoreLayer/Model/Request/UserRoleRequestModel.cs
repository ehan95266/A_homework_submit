using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.Authentication.ApplicationCoreLayer.Model.Request
{
	public class UserRoleRequestModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage= "UserId is required")]
        public int UserId { get; set; }
        [Required(ErrorMessage = "RoleId is required")]
        public int RoleId { get; set; }
    }
}

