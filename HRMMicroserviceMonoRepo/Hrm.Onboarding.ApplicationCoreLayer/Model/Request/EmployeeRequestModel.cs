using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Onboarding.ApplicationCoreLayer.Model.Request
{
	public class EmployeeRequestModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        public string? MiddleName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "SSN is required")]
        public string SSN { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string CurrentAddress { get; set; }

        public DateTime HireDate { get; set; }
        public int EmployeeRoleId { get; set; }
        public int EmployeeCategoryId { get; set; }
        public DateTime EndDate { get; set; }
        public int EmployeeStatusId { get; set; }
    }
}

