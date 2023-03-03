using System;
using Hrm.Recruiting.ApplicationCoreLayer.Model.Request;
using Hrm.Recruiting.ApplicationCoreLayer.Model.Response;

namespace Hrm.Recruiting.ApplicationCoreLayer.Contract.Service
{
	public interface ICandidateServiceAsync
	{
        Task<int> AddCandidateAsync(CandidateRequestModel model);
        Task<int> UpdateCandidateAsync(CandidateRequestModel model);
        Task<int> DeleteCandidateAsync(int id);
        Task<CandidateResponseModel> GetCandidateByIdAsync(int id); //will return response to client
        Task<IEnumerable<CandidateResponseModel>> GetAllCandidatesAsync(); //will return response to client

    }
}

