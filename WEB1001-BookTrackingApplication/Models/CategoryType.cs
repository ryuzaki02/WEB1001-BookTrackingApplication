using System;
using System.ComponentModel.DataAnnotations;

namespace WEB1001_BookTrackingApplication.Models
{
	public class CategoryType
	{
		[Key]
		public int CategoryTypeId { get; set; }
		[Required]
		public string Name { get; set; }
	}
}

