using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.giamkichsan.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PresidentController : ControllerBase
	{
		IEnumerable<string> _presidents = new List<string> {
			"Biden", "Trump", "Bush", "Clinton"
		};
		public IEnumerable<string> Index()
		{
			return _presidents;
		}
	}
}
