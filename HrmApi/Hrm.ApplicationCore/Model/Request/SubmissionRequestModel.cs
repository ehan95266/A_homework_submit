﻿using System;
namespace Hrm.ApplicationCore.Model.Request
{
    public class SubmissionRequestModel
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public int JobRequirementId { get; set; }
        public DateTime AppliedOn { get; set; }
    }
}

