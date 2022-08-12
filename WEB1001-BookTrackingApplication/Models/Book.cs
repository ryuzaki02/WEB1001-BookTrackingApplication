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
		public Category Category { get; set; }
		[Required]
        [EmailAddress]
		public string Author { get; set; }
	}
}

