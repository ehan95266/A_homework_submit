﻿using System;
using HRM.ApplicationCore.Contract.Repository;
using HRM.ApplicationCore.Entity;
using HRM.Infrastructure.Data;

namespace HRM.Infrastructure.Repository
{
	public class EmployeeRepositoryAsync:BaseRepositoryAsync<Employee>, IEmployeeRepositoryAsync
    {
		public EmployeeRepositoryAsync(HRMDbContext _context):base(_context)
		{
		}
	}
}

