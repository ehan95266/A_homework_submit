using System;
using Hrm.Recruiting.ApplicationCoreLayer.Contract.Repository;
using Hrm.Recruiting.ApplicationCoreLayer.Entity;
using Hrm.Recruiting.Infrastructure.Data;

namespace Hrm.Recruiting.Infrastructure.Repository
{
    public class JobCategoryRepositoryAsync : BaseRepositoryAsync<JobCategory>, IJobCategoryRepositoryAsync
    {
        public JobCategoryRepositoryAsync(RecruitmentDbContext _context) : base(_context)
        {
        }
    }
}

