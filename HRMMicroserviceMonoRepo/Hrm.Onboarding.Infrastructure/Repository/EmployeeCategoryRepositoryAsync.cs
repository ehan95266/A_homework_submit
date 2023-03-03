using System;
using Hrm.Onboarding.ApplicationCoreLayer.Contract.Repository;
using Hrm.Onboarding.ApplicationCoreLayer.Entity;
using Hrm.Onboarding.Infrastructure.Data;

namespace Hrm.Onboarding.Infrastructure.Repository
{
    public class EmployeeCategoryRepositoryAsync : BaseRepositoryAsync<EmployeeCategory>, IEmployeeCategoryRepositoryAsync
    {
        public EmployeeCategoryRepositoryAsync(OnboardingDbContext _context) : base(_context)
        {
        }
    }
}

