using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.Authentication.ApplicationCoreLayer.Model.Response
{
	public class UserRoleResponseModel
	{
        public int Id { get; set; }
        
        public int UserId { get; set; }
        
        public int RoleId { get; set; }
    }
}

