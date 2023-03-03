using System;
using Hrm.Interview.ApplicationCoreLayer.Model.Reponse;
using Hrm.Interview.ApplicationCoreLayer.Model.Request;

namespace Hrm.Interview.ApplicationCoreLayer.Contract.Service
{
	public interface IInterviewerServiceAsync
	{
        Task<int> AddInterviewerAsync(InterviewerRequestModel model);
        Task<int> UpdateInterviewerAsync(InterviewerRequestModel model);
        Task<int> DeleteInterviewerAsync(int id);
        Task<InterviewerResponseModel> GetInterviewerByIdAsync(int id);
        Task<IEnumerable<InterviewerResponseModel>> GetAllInterviewerAsync();
    }
}

