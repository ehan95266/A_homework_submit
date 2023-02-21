using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.ApplicationCore.Model.Request
{
	public class FeedbackRequestModel
	{
        public int Id { get; set; }
        public int InterviewId { get; set; }
        
        public string Description { get; set; }
        public bool Hired { get; set; }
    }
}

