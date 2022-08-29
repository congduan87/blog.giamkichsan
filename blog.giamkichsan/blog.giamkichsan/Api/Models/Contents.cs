using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blog.giamkichsan.Api.Models
{
	[Table(name: "Blogs_Contents")]
	public class Contents
	{
		public int ID { get; set; }
		public int CategoriesID { get; set; }
		[MaxLength(500)]
		public string Title { get; set; }
		[MaxLength(22)]
		public string DateCreate { get; set; }
		public string Author { get; set; }
		public int Action { get; set; }
	}
}
