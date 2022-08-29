using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tracuu.giamkichsan.Entities
{
	[Table("TraCuu_PersionCommunityMedia")]
	public class PersionCommunityMediaEntity
	{
		[Key]
		public int ID { get; set; }
		public int MediaType { get; set; }
		public int PersionCommunityID { get; set; }
		[MaxLength(500)]
		public string Name { get; set; }
	}
}
