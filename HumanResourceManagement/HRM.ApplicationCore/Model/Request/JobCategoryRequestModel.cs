﻿using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.ApplicationCore.Model.Request
{
	public class JobCategoryRequestModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]

        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}

