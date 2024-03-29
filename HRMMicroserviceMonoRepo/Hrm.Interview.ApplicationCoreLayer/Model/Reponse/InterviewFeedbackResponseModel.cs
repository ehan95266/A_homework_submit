﻿using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Interview.ApplicationCoreLayer.Model.Reponse
{
	public class InterviewFeedbackResponseModel
	{
        public int Id { get; set; }
        [Required]
        public int Rating { get; set; }
        
        public string Comment { get; set; }
    }
}

