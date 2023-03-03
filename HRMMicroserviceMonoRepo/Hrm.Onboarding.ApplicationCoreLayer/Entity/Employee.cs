using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Onboarding.ApplicationCoreLayer.Entity
{
	public class Employee
	{
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string FirstName { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string LastName { get; set; }

        public string? MiddleName { get; set; }

        [Required]
        [Column(TypeName = "varchar(70)")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string SSN { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string CurrentAddress { get; set; }

        public DateTime HireDate { get; set; }
        public int EmployeeRoleId { get; set; }
        public int EmployeeCategoryId { get; set; }
        public DateTime EndDate { get; set; }
        public int EmployeeStatusId { get; set; }
        
        //navigation property
        public EmployeeRole EmployeeRole { get; set; }
        public EmployeeStatus EmployeeStatus { get; set; }
        public EmployeeCategory EmployeeCategory { get; set; }
    }
}

