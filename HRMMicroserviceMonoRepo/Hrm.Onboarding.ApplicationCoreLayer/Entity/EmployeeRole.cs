using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.Onboarding.ApplicationCoreLayer.Entity
{
	public class EmployeeRole
	{
		public int Id { get; set; }
        [Required, Column(TypeName = "varchar(50)")]
        public string Name { get; set; }
        [Required, Column(TypeName = "varchar(15)")]
        public string ABBR { get; set; }
	}
}

