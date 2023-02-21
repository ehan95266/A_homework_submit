using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.ApplicationCore.Model.Response
{
	public class CandidateResponseModel //no need for validation because we are display to client, only validate when receiving input
	{
        public int Id { get; set; }
       
        public string FirstName { get; set; }

        public string LastName { get; set; }
      
        public string Mobile { get; set; }
      
        public string EmailId { get; set; }
        
        public string? ResumeUrl { get; set; }
       
        //public string CurrentAddress { get; set; }
    }
}

