using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Interview.ApplicationCoreLayer.Model.Request
{
	public class InterviewTypeRequestModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage ="Description is required")]
        public string Description { get; set; }
    }
}

