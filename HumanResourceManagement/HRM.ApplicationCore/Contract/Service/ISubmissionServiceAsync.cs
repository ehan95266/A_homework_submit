using System;
using HRM.ApplicationCore.Model.Request;
using HRM.ApplicationCore.Model.Response;
namespace HRM.ApplicationCore.Contract.Service
{
	public interface ISubmissionServiceAsync
	{
        Task<int> AddSubmissiontAsync(SubmissionRequestModel model);
        Task<int> UpdateSubmissionAsync(SubmissionRequestModel model);
        Task<int> DeleteSubmissionAsync(int id);
        Task<SubmissionResponseModel> GetSubmissionByIdAsync(int id);
        Task<IEnumerable<SubmissionResponseModel>> GetAllSubmissionsAsync();
    }
}

