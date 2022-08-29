using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tracuu.giamkichsan.Model;
using tracuu.giamkichsan.Services;

namespace tracuu.giamkichsan.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
		public List<PersonCommunityModel> personCommunitiesModel { get; set; }
		//private PersonCommunityServices personCommunityServices = new PersonCommunityServices();
		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public void OnGet(string term)
		{
			ViewData["Title"] = "người nổi tiếng";
			if (string.IsNullOrWhiteSpace(term))
			{
				personCommunitiesModel = new List<PersonCommunityModel>();
				personCommunitiesModel.Add(new PersonCommunityModel()
				{
					ID = 1,
					Name = "Phan Thị Mỹ Tâm",
					Address = "Quảng Nam",
					Alias = "Mỹ Tâm",
					Birthday = "16/01/1981",
					Facebook = "https://vi.wikipedia.org/wiki/M%E1%BB%B9_T%C3%A2m",
					Tiktok = "https://vi.wikipedia.org/wiki/M%E1%BB%B9_T%C3%A2m",
					Wikipedia = "https://vi.wikipedia.org/wiki/M%E1%BB%B9_T%C3%A2m",
					WorkCategoryName = "Ca sĩ",
					Youtube = "https://vi.wikipedia.org/wiki/M%E1%BB%B9_T%C3%A2m",
					Image = "/images/Author/MyTam.jpg"
				});
				personCommunitiesModel.Add(new PersonCommunityModel()
				{
					ID = 2,
					Name = "Phạm Đan Trường",
					Address = "Hồ Chí Minh",
					Alias = "Đan Trường",
					Birthday = "29/11/1976",
					Facebook = "",
					Tiktok = "",
					Wikipedia = "https://vi.wikipedia.org/wiki/%C4%90an_Tr%C6%B0%E1%BB%9Dng",
					WorkCategoryName = "Ca sĩ",
					Youtube = "",
					Image = "/images/Author/DanTruong.png"
				});
			}
			else
			{
				personCommunitiesModel = new List<PersonCommunityModel>();
				//personCommunitiesModel = personCommunityServices.GetAll(x => x.Name.Contains(name) || x.Alias.Contains(name));
			}

		}
	}
}
