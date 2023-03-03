using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.Recruiting.ApplicationCoreLayer.Model.Request
{
	public class CandidateRequestModel
	{
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Mobile is required")]
        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string? ResumeUrl { get; set; }

    }
}

