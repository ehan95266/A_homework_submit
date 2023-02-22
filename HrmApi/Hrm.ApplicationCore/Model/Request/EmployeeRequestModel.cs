using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.ApplicationCore.Model.Request
{
	public class EmployeeRequestModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "First Name is required")]

        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]

        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required")]

        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }
        public DateTime DOB { get; set; }


        public string SSN { get; set; }
        public string CurrentAddress { get; set; }

        [Required(ErrorMessage = "Mobile is required")]
        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }
        public DateTime HireDate { get; set; }
        public int EmployeeRoleId { get; set; }
        public int EmployeeTypeId { get; set; }
        public DateTime EndDate { get; set; }
        public int EmployeeStatusId { get; set; }
        public int ManagerId { get; set; }
    }
}

