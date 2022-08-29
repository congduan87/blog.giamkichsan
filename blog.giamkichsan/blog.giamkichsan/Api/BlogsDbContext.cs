using blog.giamkichsan.Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace blog.giamkichsan.Api
{
	public class BlogsDbContext:DbContext
	{
		public DbSet<Categories> Categories { get; set; }
		public DbSet<ContentDetails> ContentDetails { get; set; }
		public DbSet<Contents> Contents { get; set; }
	}
}
