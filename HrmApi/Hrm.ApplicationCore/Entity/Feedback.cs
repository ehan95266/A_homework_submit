using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.ApplicationCore.Entity
{
    public class Feedback
    {
        public int Id { get; set; }
        public int InterviewId { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Description { get; set; }
        public bool Hired { get; set; }

        public Interview Interview { get; set; }

    }
}

