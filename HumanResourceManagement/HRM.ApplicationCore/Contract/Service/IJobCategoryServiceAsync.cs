using System;
using HRM.ApplicationCore.Model.Request;
using HRM.ApplicationCore.Model.Response;
namespace HRM.ApplicationCore.Contract.Service
{
	public interface IJobCategoryServiceAsync
	{
        Task<int> AddJobCategoryAsync(JobCategoryRequestModel model);
        Task<int> UpdateJobCategoryAsync(JobCategoryRequestModel model);
        Task<int> DeleteJobCategoryAsync(int id);
        Task<JobCategoryResponseModel> GetJobCategoryByIdAsync(int id);
        Task<IEnumerable<JobCategoryResponseModel>> GetAllJobCategoriesAsync();
    }
}

