﻿using System;
using System.ComponentModel.DataAnnotations;

namespace HRM.ApplicationCore.Model.Response
{
	public class JobCategoryResponseModel
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}

