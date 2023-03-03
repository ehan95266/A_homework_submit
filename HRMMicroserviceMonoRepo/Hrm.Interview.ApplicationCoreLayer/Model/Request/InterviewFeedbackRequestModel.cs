using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Interview.ApplicationCoreLayer.Model.Request
{
	public class InterviewFeedbackRequestModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage ="Rating is Required")]
        public int Rating { get; set; }
        [Required(ErrorMessage ="Comment is required")]
        public string Comment { get; set; }
    }
}

