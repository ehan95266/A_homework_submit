using System;
using Hrm.Interview.ApplicationCoreLayer.Contract.Repository;
using Hrm.Interview.ApplicationCoreLayer.Entity;
using Hrm.Interview.Infrastructure.Data;

namespace Hrm.Interview.Infrastructure.Repository
{
    public class RecruiterRepositoryAsync : BaseRepositoryAsync<Recruiter>, IRecruiterRepositoryAsync
    {
        public RecruiterRepositoryAsync(InterviewDbContext _context) : base(_context)
        {
        }
    }
}

