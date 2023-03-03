using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Authentication.ApplicationCoreLayer.Model.Request
{
	public class AccountRequestModel
	{
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Email Id is required")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }
        public int RoleId { get; set; }
        [Required(ErrorMessage = "First Name is required")] 
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        public string HashPassword { get; set; }
    }
}

