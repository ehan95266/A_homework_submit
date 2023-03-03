using System;
using Hrm.Interview.ApplicationCoreLayer.Contract.Repository;
using Hrm.Interview.ApplicationCoreLayer.Entity;
using Hrm.Interview.Infrastructure.Data;

namespace Hrm.Interview.Infrastructure.Repository
{
    public class InterviewsRepositoryAsync : BaseRepositoryAsync<Interviews>, IInterviewsRepositoryAsync
    {
        public InterviewsRepositoryAsync(InterviewDbContext _context) : base(_context)
        {
        }
    }
}

