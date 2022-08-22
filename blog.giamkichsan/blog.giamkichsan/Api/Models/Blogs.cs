using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.giamkichsan.Api.Models
{
	public class Blogs
	{
		public int ID { get; set; }
		public int CategoriesID { get; set; }
		public string Title { get; set; }
		public string DateCreate { get; set; }
		public string Author { get; set; }
		public int Action { get; set; }
	}
}
