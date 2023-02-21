using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRM.ApplicationCore.Model.Request
{
	public class JobRequirementRequestModel
	{
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required")]

        public string Title { get; set; }
        
        public string Description { get; set; }
        public int TotalPositions { get; set; }
        public DateTime PostingDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public int JobCategoryId { get; set; }
        public bool IsActive { get; set; }
    }
}

