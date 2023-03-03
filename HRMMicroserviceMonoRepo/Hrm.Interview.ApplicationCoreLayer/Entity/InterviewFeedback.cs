using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Interview.ApplicationCoreLayer.Entity
{
	public class InterviewFeedback
    {
		public int Id { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required, Column(TypeName = "varchar(100)")]
        public string Comment { get; set; }

	}
}

