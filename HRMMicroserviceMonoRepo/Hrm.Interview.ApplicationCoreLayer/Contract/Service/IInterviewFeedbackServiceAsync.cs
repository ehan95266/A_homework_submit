using System;
using Hrm.Interview.ApplicationCoreLayer.Model.Reponse;
using Hrm.Interview.ApplicationCoreLayer.Model.Request;
namespace Hrm.Interview.ApplicationCoreLayer.Contract.Service
{
	public interface IInterviewFeedbackServiceAsync
	{
        Task<int> AddInterviewFeedbackAsync(InterviewFeedbackRequestModel model);
        Task<int> UpdateInterviewFeedbackAsync(InterviewFeedbackRequestModel model);
        Task<int> DeleteInterviewFeedbackAsync(int id);
        Task<InterviewFeedbackResponseModel> GetInterviewFeedbackByIdAsync(int id);
        Task<IEnumerable<InterviewFeedbackResponseModel>> GetAllInterviewFeedbackAsync();
    }
}

