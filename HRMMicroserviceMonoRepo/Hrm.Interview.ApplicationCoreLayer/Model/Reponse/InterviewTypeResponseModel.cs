using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Interview.ApplicationCoreLayer.Model.Reponse
{
	public class InterviewTypeResponseModel
	{
        public int Id { get; set; }
        
        public string Description { get; set; }
    }
}

