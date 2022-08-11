using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WEB1001_BookTrackingApplication.Models
{
	public class Book
	{
		[Key]
		public int BookId { get; set; }
		[Required]
		public string Title { get; set; }
		[Required]
		public List<Category> Categories { get; set; }
		[Required]
		public string Author { get; set; }
	}
}

