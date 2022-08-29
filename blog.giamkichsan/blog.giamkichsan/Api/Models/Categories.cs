using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blog.giamkichsan.Api.Models
{
	[Table(name: "Blogs_Categories")]
	public class Categories
	{
		[Key]
		public int ID { get; set; }
		public int ParentID { get; set; }
		[MaxLength(500)]
		public string Name { get; set; }
		[MaxLength(4000)]
		public string Description { get; set; }
		public int OrderNumber { get; set; }
	}
}
