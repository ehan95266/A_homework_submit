using System;
using HRM.ApplicationCore.Model.Request;
using HRM.ApplicationCore.Model.Response;
namespace HRM.ApplicationCore.Contract.Service
{
	public interface IInterviewStatusServiceAsync
	{
        Task<int> AddInterviewStatusAsync(InterviewStatusRequestModel model);
        Task<int> UpdateInterviewStatusAsync(InterviewStatusRequestModel model);
        Task<int> DeleteInterviewStatusAsync(int id);
        Task<InterviewStatusResponseModel> GetInterviewStatusByIdAsync(int id);
        Task<IEnumerable<InterviewStatusResponseModel>> GetAllInterviewStatusAsync();
    }
}

