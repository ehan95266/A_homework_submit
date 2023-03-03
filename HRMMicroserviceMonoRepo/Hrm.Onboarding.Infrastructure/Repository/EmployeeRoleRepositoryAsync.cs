using System;
using Hrm.Onboarding.ApplicationCoreLayer.Contract.Repository;
using Hrm.Onboarding.ApplicationCoreLayer.Entity;
using Hrm.Onboarding.Infrastructure.Data;

namespace Hrm.Onboarding.Infrastructure.Repository
{
    public class EmployeeRoleRepositoryAsync : BaseRepositoryAsync<EmployeeRole>, IEmployeeRoleRepositoryAsync
    {
        public EmployeeRoleRepositoryAsync(OnboardingDbContext _context) : base(_context)
        {
        }
    }
}

