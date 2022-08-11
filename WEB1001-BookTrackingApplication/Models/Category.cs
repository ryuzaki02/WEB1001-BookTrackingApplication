using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WEB1001_BookTrackingApplication.Models
{
	public class Category
	{
		[Key]
		public int CategoryId { get; set; }
		[Required]
		public List<CategoryType> CategoryTypes { get; set; }
		[Required]
		public string Description { get; set; }
	}
}

