using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace blog.giamkichsan.Api.Models
{
	//[Table(name: "Blogs_ContentDetails")]
	public class ContentDetails
	{
		public int ID { get; set; }
		public int ContentsID { get; set; }
		[MaxLength(4000)]
		public string Description { get; set; }
		public int OrderNumber { get; set; }
	}
}
