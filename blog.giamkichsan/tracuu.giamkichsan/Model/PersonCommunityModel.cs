using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tracuu.giamkichsan.Entities;

namespace tracuu.giamkichsan.Model
{
	[Serializable]
	public class PersonCommunityModel: PersionCommunityEntity
	{
		public string WorkCategoryName { get; set; }
		public string Facebook { get; set; }
		public string Youtube { get; set; }
		public string Tiktok { get; set; }
		public string Wikipedia { get; set; }
	}
}
