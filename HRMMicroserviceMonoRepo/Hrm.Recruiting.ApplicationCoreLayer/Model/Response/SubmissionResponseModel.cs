﻿using System;
namespace Hrm.Recruiting.ApplicationCoreLayer.Model.Response
{
	public class SubmissionResponseModel
	{
        public int Id { get; set; }

        public int CandidateId { get; set; }

        public int JobRequirementId { get; set; }
        public DateTime SubmittedOn { get; set; }
        public int SubmissionStatusId { get; set; }
        public DateTime ConfirmedOn { get; set; }
        public DateTime RejectedOn { get; set; }

    }
}

