using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Recruiting.ApplicationCoreLayer.Entity
{
	public class SubmissionStatus
	{
        public int Id { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string? Description { get; set; }

    }
}

