using System;
namespace Hrm.Interview.ApplicationCoreLayer.Entity
{
	public class Interviews
	{
        public int Id { get; set; }
        public int RecruiterId { get; set; }
        public int SubmissionId { get; set; }
        public DateTime ScheduledOn { get; set; }
        public int InterviewRound { get; set; }
        public int InterviewTypeId { get; set; }
        public int InterviewStatusId { get; set; }
        public int InterviewerId { get; set; }
        public int FeedbackId { get; set; }

        //navigation
        public InterviewType InterviewType { get; set; }
        public Interviewer Interviewer { get; set; }
        public Recruiter Recruiter { get; set; }
        public InterviewFeedback InterviewFeedback { get; set; }
    }
}

