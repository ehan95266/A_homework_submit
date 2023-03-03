using System;
using Hrm.Recruiting.ApplicationCoreLayer.Model.Request;
using Hrm.Recruiting.ApplicationCoreLayer.Model.Response;
namespace Hrm.Recruiting.ApplicationCoreLayer.Contract.Service
{
	public interface ISubmissionStatusServiceAsync
	{
        Task<int> AddSubmissionStatusAsync(SubmissionStatusRequestModel model); //client request to server
        Task<int> UpdateSubmissionStatusAsync(SubmissionStatusRequestModel model);
        Task<int> DeleteSubmissionStatusAsync(int id);
        Task<SubmissionStatusResponseModel> GetSubmissionStatusByIdAsync(int id);
        Task<IEnumerable<SubmissionStatusResponseModel>> GetAllSubmissionStatusAsync();

    }
}

