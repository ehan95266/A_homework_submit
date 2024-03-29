﻿using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Interview.ApplicationCoreLayer.Entity
{
	public class InterviewType
	{
		public int Id { get; set; }
        [Required, Column(TypeName = "varchar(100)")]
        public string Description { get; set; }
	}
}

