using System;
using HRM.ApplicationCore.Model.Request;
using HRM.ApplicationCore.Model.Response;
namespace HRM.ApplicationCore.Contract.Service
{
	public interface IInterviewServiceAsync
	{
		
            Task<int> AddInterviewAsync(InterviewRequestModel model);
            Task<int> UpdateInterviewAsync(InterviewRequestModel model);
            Task<int> DeleteInterviewAsync(int id);
            Task<InterviewResponseModel> GetInterviewByIdAsync(int id);
            Task<IEnumerable<InterviewResponseModel>> GetAllInterviewsAsync();
        
	}
}

