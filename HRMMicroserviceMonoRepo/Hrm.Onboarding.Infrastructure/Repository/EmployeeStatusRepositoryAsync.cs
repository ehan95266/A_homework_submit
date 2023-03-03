using System;
using Hrm.Onboarding.ApplicationCoreLayer.Contract.Repository;
using Hrm.Onboarding.ApplicationCoreLayer.Entity;
using Hrm.Onboarding.Infrastructure.Data;

namespace Hrm.Onboarding.Infrastructure.Repository
{
    public class EmployeeStatusRepositoryAsync : BaseRepositoryAsync<EmployeeStatus>, IEmployeeStatusRepositoryAsync
    {
        public EmployeeStatusRepositoryAsync(OnboardingDbContext _context) : base(_context)
        {
        }
    }
}

