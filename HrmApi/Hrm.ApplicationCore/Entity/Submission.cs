﻿using System;
namespace Hrm.ApplicationCore.Entity
{
    public class Submission
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public int JobRequirementId { get; set; }
        public DateTime AppliedOn { get; set; }

        //navigation property
        public Candidate Candidate { get; set; }
        public JobRequirement JobRequirement { get; set; }
    }
}

