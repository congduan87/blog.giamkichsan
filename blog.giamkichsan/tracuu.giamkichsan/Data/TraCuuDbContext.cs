using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tracuu.giamkichsan.Entities;

namespace tracuu.giamkichsan.Data
{
	public class TraCuuDbContext:DbContext
	{
		public DbSet<PersionCommunityMediaEntity> PersionCommunityMedias { get; set; }
		public DbSet<PersionCommunityEntity> PersionCommunities { get; set; }
		public DbSet<WorkCategoryEntity> WorkCategories { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=giamkichsan.com;Database=gia28291_Blogs;User ID=gia28291_Blogs;Password=L@nThuH@i1;Trusted_Connection=True");
		}
	}
}
