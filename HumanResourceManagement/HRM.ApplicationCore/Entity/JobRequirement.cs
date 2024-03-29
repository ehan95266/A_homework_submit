﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.ApplicationCore.Entity
{
	public class JobRequirement
	{
		//property will be column name in jobrequirement table
		public int Id { get; set; }
		[Required]
		[Column(TypeName = "varchar(100)")]
		public string Title { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Description { get; set; }
		public int TotalPositions { get; set; }
		public DateTime PostingDate { get; set; }
		public DateTime ClosingDate { get; set; }
		public int JobCategoryId { get; set; }
		public bool IsActive { get; set; }

		//navigational property will not be used to create column, it is used to create relation
		public JobCategory JobCategory { get; set; }

	}
}

