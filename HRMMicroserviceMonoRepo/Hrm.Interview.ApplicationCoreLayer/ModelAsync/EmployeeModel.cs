using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Interview.ApplicationCoreLayer.ModelAsync
{
	public class EmployeeModel
	{
        public int Id { get; set; }
        
        public string FirstName { get; set; }
     
        public string LastName { get; set; }

        public string MiddleName { get; set; }

        
        public string EmailId { get; set; }

       
        public string SSN { get; set; }

        
        public string CurrentAddress { get; set; }

        public DateTime HireDate { get; set; }
        public int EmployeeRoleId { get; set; }
        public int EmployeeCategoryId { get; set; }
        public DateTime EndDate { get; set; }
        public int EmployeeStatusId { get; set; }
    }
}

