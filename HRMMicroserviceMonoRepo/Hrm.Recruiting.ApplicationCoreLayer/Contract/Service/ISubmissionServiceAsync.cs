using System;
using Hrm.Recruiting.ApplicationCoreLayer.Model.Request;
using Hrm.Recruiting.ApplicationCoreLayer.Model.Response;
namespace Hrm.Recruiting.ApplicationCoreLayer.Contract.Service
{
	public interface ISubmissionServiceAsync
	{
        Task<int> AddSubmissionAsync(SubmissionRequestModel model); //client request to server
        Task<int> UpdateSubmissionAsync(SubmissionRequestModel model);
        Task<int> DeleteSubmissionAsync(int id);
        Task<SubmissionResponseModel> GetSubmissionByIdAsync(int id);
        Task<IEnumerable<SubmissionResponseModel>> GetAllSubmissionAsync();
    }

}

