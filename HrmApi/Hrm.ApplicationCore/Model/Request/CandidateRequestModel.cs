using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.ApplicationCore.Model.Request
{

        public class CandidateRequestModel
        {
            public int Id { get; set; }
            [Required(ErrorMessage = "First Name is required")] //custom error message for candidate create.cshtml
            public string FirstName { get; set; }
            [Required(ErrorMessage = "Last Name is required")]
            public string LastName { get; set; }
            [Required(ErrorMessage = "Mobile number is required")]
            [DataType(DataType.PhoneNumber)]
            public string Mobile { get; set; }
            [Required(ErrorMessage = "Email Id is required")]
            [DataType(DataType.EmailAddress)]
            public string EmailId { get; set; }
        }
    
}

