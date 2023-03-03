using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.Recruiting.ApplicationCoreLayer.Entity
{
	public class Submission
	{
        public int Id { get; set; }
        [Required]
        public int CandidateId { get; set; }
        [Required]
        public int JobRequirementId { get; set; }
        public DateTime SubmittedOn { get; set; }
        public int SubmissionStatusId { get; set; }
        public DateTime ConfirmedOn { get; set; }
        public DateTime RejectedOn { get; set; }

        //navigation property
        public Candidate Candidate { get; set; }
        public JobRequirement JobRequirement { get; set; }
        public SubmissionStatus SubmissionStatus { get; set; }

    }
}

