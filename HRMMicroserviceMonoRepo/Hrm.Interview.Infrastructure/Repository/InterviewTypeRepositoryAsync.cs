using System;
using Hrm.Interview.ApplicationCoreLayer.Contract.Repository;
using Hrm.Interview.ApplicationCoreLayer.Entity;
using Hrm.Interview.Infrastructure.Data;

namespace Hrm.Interview.Infrastructure.Repository
{
	public class InterviewTypeRepositoryAsync:BaseRepositoryAsync<InterviewType>, IInterviewTypeRepositoryAsync
	{
        public InterviewTypeRepositoryAsync(InterviewDbContext _context) : base(_context)
        {
        }
    }
}

