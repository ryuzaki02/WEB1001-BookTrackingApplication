using System;
using Microsoft.EntityFrameworkCore;
using WEB1001_BookTrackingApplication.Models;

namespace WEB1001_BookTrackingApplication.Data
{
	public class BookContext : DbContext
	{
		public BookContext(DbContextOptions<BookContext> options)
			: base(options)
		{

		}

		public DbSet<Book> Books { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<CategoryType> CategoryTypes { get; set; }
	}
}

