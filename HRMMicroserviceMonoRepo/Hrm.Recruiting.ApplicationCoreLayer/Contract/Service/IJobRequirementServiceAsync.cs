using System;
using Hrm.Recruiting.ApplicationCoreLayer.Model.Request;
using Hrm.Recruiting.ApplicationCoreLayer.Model.Response;
namespace Hrm.Recruiting.ApplicationCoreLayer.Contract.Service
{
	public interface IJobRequirementServiceAsync
	{
        Task<int> AddJobRequirementAsync(JobRequirementRequestModel model);
        Task<int> UpdateJobRequirementAsync(JobRequirementRequestModel model);
        Task<int> DeleteJobRequirementAsync(int id);
        Task<JobRequirementResponseModel> GetJobRequirementByIdAsync(int id);
        Task<IEnumerable<JobRequirementResponseModel>> GetAllJobRequirementAsync();

    }
}

