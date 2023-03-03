using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.Recruiting.ApplicationCoreLayer.Model.Request
{
	public class SubmissionRequestModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "Candidate Id is required")]
        public int CandidateId { get; set; }
        [Required(ErrorMessage = "Job requirement Id is required")]
        public int JobRequirementId { get; set; }
        public DateTime SubmittedOn { get; set; }
        public int SubmissionStatusId { get; set; }
        public DateTime ConfirmedOn { get; set; }
        public DateTime RejectedOn { get; set; }
    }
}

