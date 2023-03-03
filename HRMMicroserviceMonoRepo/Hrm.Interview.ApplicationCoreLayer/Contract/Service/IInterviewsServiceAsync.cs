using System;
using Hrm.Interview.ApplicationCoreLayer.Model.Reponse;
using Hrm.Interview.ApplicationCoreLayer.Model.Request;
namespace Hrm.Interview.ApplicationCoreLayer.Contract.Service
{
	public interface IInterviewsServiceAsync
	{
        Task<int> AddInterviewsAsync(InterviewsRequestModel model);
        Task<int> UpdateInterviewsAsync(InterviewsRequestModel model);
        Task<int> DeleteInterviewsAsync(int id);
        Task<InterviewsResponseModel> GetInterviewsByIdAsync(int id);
        Task<IEnumerable<InterviewsResponseModel>> GetAllInterviewsAsync();
    }
}

