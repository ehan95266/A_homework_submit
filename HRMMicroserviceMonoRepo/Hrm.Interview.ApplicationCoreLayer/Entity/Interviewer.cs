using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Interview.ApplicationCoreLayer.Entity
{

	public class Interviewer
    {
		public int Id { get; set; }
        [Required, Column(TypeName = "varchar(20)")]
        public string FirstName { get; set; }

        [Required, Column(TypeName = "varchar(20)")]
        public string LastName { get; set; }
        public int EmployeeId { get; set; }

    }
}

