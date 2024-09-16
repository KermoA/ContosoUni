﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ContosoUni.Models
{
	public class Instructor
	{
		public int ID { get; set; }

		[Required]
		[StringLength(50, MinimumLength = 2)]
		[Display(Name = "Last Name")]
		public string LastName { get; set; }

		[Required]
		[StringLength(50)]
		[Display(Name = "First Name")]
		[Column("FirstName")]
		public string FirstMidName { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		[Display(Name = "Hire Date")]
		public DateTime HireDate { get; set; }

		[Display(Name = "Full Name")]
		public string FullName
		{
			get
			{
				return LastName + "," + FirstMidName;
			}
		}
		public ICollection<CourseAssignment>? CourseAssignments { get; set; }
		public OfficeAssignment OfficeAssignment { get; set; }
	}
}
	

