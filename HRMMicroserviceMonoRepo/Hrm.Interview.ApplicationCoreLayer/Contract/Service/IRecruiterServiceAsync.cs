using System;
using Hrm.Interview.ApplicationCoreLayer.Model.Reponse;
using Hrm.Interview.ApplicationCoreLayer.Model.Request;
namespace Hrm.Interview.ApplicationCoreLayer.Contract.Service
{
	public interface IRecruiterServiceAsync
	{
        Task<int> AddRecruiterAsync(RecruiterRequestModel model);
        Task<int> UpdateRecruiterAsync(RecruiterRequestModel model);
        Task<int> DeleteRecruiterAsync(int id);
        Task<RecruiterResponseModel> GetRecruiterByIdAsync(int id);
        Task<IEnumerable<RecruiterResponseModel>> GetAllRecruiterAsync();
    }
}

