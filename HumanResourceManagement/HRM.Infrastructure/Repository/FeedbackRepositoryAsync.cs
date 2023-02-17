using System;
using HRM.ApplicationCore.Contract.Repository;
using HRM.ApplicationCore.Entity;
using HRM.Infrastructure.Data;
namespace HRM.Infrastructure.Repository
{
	public class FeedbackRepositoryAsync:BaseRepositoryAsync<Feedback>
	{
		public FeedbackRepositoryAsync(HRMDbContext _context):base(_context)
		{
		}
	}
}

