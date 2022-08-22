using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.giamkichsan.Api.Models
{
	public class Categories
	{
		public int ID { get; set; }
		public int ParentID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int OrderNumber { get; set; }
	}
}
