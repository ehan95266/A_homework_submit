using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Recruiting.ApplicationCoreLayer.Entity
{
	public class JobRequirement
	{
        public int Id { get; set; }

        [Required, Column(TypeName = "varchar(100)")]
        public string Title { get; set; }

        [Required, Column(TypeName = "varchar(100)")]
        public string Description { get; set; }

        public int TotalPosition { get; set; }
        public int HiringManagerId { get; set; }

        [Required, Column(TypeName = "varchar(50)")]
        public string HiringManagerName { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime ClosedOn { get; set; }


        public string? ClosedReason { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;
        [Required]
        public int JobCategoryId { get; set; }
        public bool IsActive { get; set; }

        //navigational property will not be used to create column, it is used to create relation
        public JobCategory JobCategory { get; set; }
        //managerid fk? 

    }
}

