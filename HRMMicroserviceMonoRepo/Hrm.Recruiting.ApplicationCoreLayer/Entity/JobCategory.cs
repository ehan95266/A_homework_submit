﻿using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Recruiting.ApplicationCoreLayer.Entity
{
	public class JobCategory
	{
        public int Id { get; set; }

        [Required, Column(TypeName = "varchar(20)")]
        public string Title { get; set; }

        [Required, Column(TypeName = "varchar(100)")]
        public string Description { get; set; }

        public bool IsActive { get; set; } = true;

    }
}

