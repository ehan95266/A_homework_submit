﻿using System;
namespace Hrm.ApplicationCore.Model.Response
{
    public class JobRequirementResponseModel
    {
        public int Id { get; set; }


        public string Title { get; set; }

        public string Description { get; set; }
        public int TotalPositions { get; set; }
        public DateTime PostingDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public int JobCategoryId { get; set; }
        public bool IsActive { get; set; }
    }
}

