using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.giamkichsan.Api.Models
{
	public class BlogsDetail
	{
		public int ID { get; set; }
		public int BlogsID { get; set; }
		public string Paragraph { get; set; }
		public int OrderNumber { get; set; }
	}
}
