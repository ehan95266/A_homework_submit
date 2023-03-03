using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.Authentication.ApplicationCoreLayer.Model.Response
{
	public class AccountResponseModel
	{
        public int Id { get; set; }
        public int EmployeeId { get; set; }
       
        public string EmailId { get; set; }
        public int RoleId { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        public string HashPassword { get; set; }
    }
}

